using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Security.Principal;

namespace IPModifer
{
    public partial class MainForm : Form
    {
        DataTable FanAn = null;
        NetworkAdapterMannager nmg;
        ConfigMannager cfm;

        public MainForm()
        {
            nmg = new NetworkAdapterMannager();
            InitializeComponent();
            fullcbFanAn();
            fullcbNetworkInterface();
        }

        /// <summary>
        /// 响应刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.fullcbNetworkInterface();
            tbLog.AppendText("\r\n刷新完成---" + System.DateTime.Now);
        }

        private void cbNetworkInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            Network ntk =  nmg.getNICInfoByCaption(cbNetworkInterface.Text);
            this.displayNetworkInfo(ntk);
        }

        /// <summary>
        /// 显示Network信息到界面
        /// </summary>
        /// <param name="ntk">Network对象</param>
        private void displayNetworkInfo(Network ntk)
        {
            tbNetworkInterfaceID.Text = ntk.Id;
            tbName.Text = ntk.Name;
            tbIp.Text = ntk.Ip;
            tbGateway.Text = ntk.Gateway;
            tbMask.Text = ntk.Mask;
            tbDNS01.Text = ntk.Dns1;
            tbDNS02.Text = ntk.Dns2;
        }

        private void displayNetworkInfo()
        {
            tbName.Text = "";
            tbIp.Text = "";
            tbMask.Text = "";
            tbGateway.Text = "";
            tbDNS01.Text = "";
            tbDNS02.Text = "";
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            string id = nmg.AllNIC1[cbNetworkInterface.Text];
            string[] ip = new string[] { tbNewIp.Text };
            string[] mask = new string[] { tbNewMask.Text };
            string[] gateway = new string[] { tbNewGateway.Text };
            string[] dns = new string[] { tbNewDNS1.Text, tbNewDNS2.Text };

            if (IsAdministrator())
            {
                MessageBox.Show("管理员权限！！！");
            }
            else
            {
                MessageBox.Show("非管理员权限！！！");
            }
            //设置ip
            nmg.setNetwork(id,ip,mask,gateway,dns);
            //获取设置的好的ip
            this.fullcbNetworkInterface();
        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// 工具栏按钮响应
        /// //////////////////////////////////////////////////////////////////////////////////////////////

        private void toolAbout_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void toolOption_Click(object sender, EventArgs e)
        {
            ConfigMannagerForm fgf = new ConfigMannagerForm();
            fgf.ShowDialog(this);
        }



        private void fullcbFanAn()
        {
            string apppath = Path.GetDirectoryName(Application.ExecutablePath);
            string mdbPath =apppath + "\\config.mdb";

            cfm = new ConfigMannager(mdbPath);
            FanAn = cfm.selectAllConfig();
            foreach (DataRow dr in FanAn.Rows)
            {
                cbFanAn.Items.Add(dr["name"].ToString());
            }
        }

        private void cbFanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbFanAn.Text;
            foreach (DataRow dr in FanAn.Rows)
            {
                if (dr["name"].ToString() == name)
                {
                    tbNewIp.Text = dr["ip"].ToString();
                    tbNewGateway.Text = dr["gateway"].ToString();
                    tbNewMask.Text = dr["mask"].ToString();
                    tbNewDNS1.Text = dr["DNS1"].ToString();
                    tbNewDNS2.Text = dr["DNS2"].ToString();
                }
            }
        }

        public static bool IsAdministrator()
        {
            bool result;
            try
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                result = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                result = false;
            }
            return result;
        }


        public void fullcbNetworkInterface()
        {
            cbNetworkInterface.Items.Clear();
            nmg.Refresh();
            foreach (var item in nmg.AllNIC1)
            {
                Console.WriteLine(item.Key+':'+item.Value);
                cbNetworkInterface.Items.Add(item.Key);
            }
            
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void tsbLog_Click(object sender, EventArgs e)
        {
            if (this.Height == 420)
            {
                this.Height = 325;
                this.tbLog.Visible = false;
            }
            else
            {
                this.Height = 420;
                this.tbLog.Visible = true;
            }

        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// 托盘
        /// //////////////////////////////////////////////////////////////////////////////////////////////

        private void tsbTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            this.notifyIcon.ShowBalloonTip(3, "提示", "软件在后台运行！如要打开，请点击图标", ToolTipIcon.Info);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
            }
            else
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            this.notifyIcon.ShowBalloonTip(3, "提示", "软件仍在运行！如要打开，请点击图标", ToolTipIcon.Info);
            e.Cancel = true;
        }
    }
}
