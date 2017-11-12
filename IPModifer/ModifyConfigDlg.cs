using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPModifer
{
    public partial class ModifyConfigDlg : Form
    {
        private Config config;
        public delegate void ConfigModifedHandler(object sender,Config args);
        public event ConfigModifedHandler myEvent;


        public ModifyConfigDlg(Config cfg)
        {
            InitializeComponent();
            this.config = cfg;
            this.displayConfig(config);
        }

        private void onMyEvent(object sender, Config args)
        {
            if (myEvent != null)
            {
                myEvent(this, args);
            }
        }

        /// <summary>
        /// 显示Config到界面
        /// </summary>
        /// <param name="cfg"></param>
        public void displayConfig(Config cfg)
        {
            this.tbID.Text = cfg.Id1.ToString();
            this.tbFAName.Text = cfg.Name;
            this.tbIP.Text = cfg.Ip;
            this.tbMask.Text = cfg.Mask;
            this.tbGateway.Text = cfg.Gateway;
            this.tbDNS1.Text = cfg.Dns1;
            this.tbDNS2.Text = cfg.Dns2;
        }

        /// <summary>
        /// 获取界面数据更新Config
        /// </summary>
        public void updateConfig()
        {
            this.config.Id1 = int.Parse(this.tbID.Text);
            this.config.Name = this.tbFAName.Text;
            this.config.Ip = this.tbIP.Text;
            this.config.Mask = this.tbMask.Text;
            this.config.Gateway = this.tbGateway.Text;
            this.config.Dns1 = this.tbDNS1.Text;
            this.config.Dns2 = this.tbDNS2.Text;
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            this.updateConfig();
            onMyEvent(this,config);
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.displayConfig(config);
        }
    }
}
