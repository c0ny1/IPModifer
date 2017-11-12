using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPModifer
{
    public partial class ConfigMannagerForm : Form
    {
        private static string mdbFileName = "config.mdb";
        private string mdbPath;
        private ConfigMannager cfgMannager;
        private DataTable dt;

        public ConfigMannagerForm()
        {
            InitializeComponent();
            string apppath = Path.GetDirectoryName(Application.ExecutablePath);
            this.mdbPath = apppath + "\\"+mdbFileName;
            this.cfgMannager = new ConfigMannager(mdbPath);
            this.displayAllConfig();
        }

        //显示所有配置方案
        private void displayAllConfig()
        {
            //dt = cdb.SelectAllData();
            dt = cfgMannager.selectAllConfig();
            this.dgvFanAn.DataSource = dt;
        }

        //刷新
        private void cmRefresh_Click(object sender, EventArgs e)
        {
            this.displayAllConfig();
        }

        //删除
        private void cmDel_Click(object sender, EventArgs e)
        {
   
            string sid = dgvFanAn.CurrentRow.Cells["id"].Value.ToString();
            
            if (string.IsNullOrWhiteSpace(sid))
            {
                MessageBox.Show("请选择要删除的数据！");
                return;
            }

            if (MessageBox.Show("确定删除", "删除", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            int id = int.Parse(sid);
            bool is_succes = cfgMannager.delConfigById(id);

            if (is_succes)
            {
                dgvFanAn.Rows.Remove(dgvFanAn.CurrentRow);
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            this.displayAllConfig();
        }

        // 添加
        private void cmAdd_Click(object sender, EventArgs e)
        {
            AddConfigDlg addconfig = new AddConfigDlg();
            addconfig.myEvent += new AddConfigDlg.AddConfigHandler(doAddConfig);
            addconfig.ShowDialog(this);
        }

        private void doAddConfig(object sender,Config cfg)
        {
            bool isSuccess = false;
            isSuccess = cfgMannager.addConfig(cfg);
            if (isSuccess)
            {
                MessageBox.Show("添加成功！！！");
                this.displayAllConfig();
            }
            else
            {
                MessageBox.Show("添加失败！！！");
            }
        }

        /// <summary>
        /// 从界面获取选中的Config
        /// </summary>
        /// <returns></returns>
        private Config getConfigFromForm()
        {
            Config cfg = new Config();
            cfg.Id1 = int.Parse(dgvFanAn.CurrentRow.Cells["id"].Value.ToString());
            Console.WriteLine(cfg.Id1);
            cfg.Name = dgvFanAn.CurrentRow.Cells["name"].Value.ToString();
            cfg.Ip = dgvFanAn.CurrentRow.Cells["ip"].Value.ToString();
            cfg.Mask= dgvFanAn.CurrentRow.Cells["mask"].Value.ToString();
            cfg.Gateway= dgvFanAn.CurrentRow.Cells["gateway"].Value.ToString();
            cfg.Dns1 = dgvFanAn.CurrentRow.Cells["dns1"].Value.ToString();
            cfg.Dns2 = dgvFanAn.CurrentRow.Cells["dns2"].Value.ToString();
            return cfg;
        }

        // 显示修改界面
        private void cmModify_Click(object sender, EventArgs e)
        {
            Config cfg = getConfigFromForm();
            ModifyConfigDlg modifyfa = new ModifyConfigDlg(cfg);
            modifyfa.myEvent += new ModifyConfigDlg.ConfigModifedHandler(doModifyConfig);
            modifyfa.ShowDialog(this);
        }
        //执行修改操作
        public void doModifyConfig(object sender,Config cfg)
        {
            bool isSuccess = false;
            isSuccess = cfgMannager.modifyConfig(cfg);
            if (isSuccess)
            {
                MessageBox.Show("修改成功！！！");
                this.displayAllConfig();
            }
            else
            {
                MessageBox.Show("修改失败！！！");
            }
        }
    }
}
