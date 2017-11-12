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
    public partial class AddConfigDlg : Form
    {
        private Config config;
        public delegate void AddConfigHandler(object sender, Config args);
        public event AddConfigHandler myEvent;

        public AddConfigDlg()
        {
            InitializeComponent();
            this.config = new Config();
        }

        public void updateConfig()
        {
            this.config.Name = this.tbFAName.Text;
            this.config.Ip = this.tbIP.Text;
            this.config.Mask = this.tbMask.Text;
            this.config.Gateway = this.tbGateway.Text;
            this.config.Dns1 = this.tbDNS1.Text;
            this.config.Dns2 = this.tbDNS2.Text;
        }

        private void onMyEvent(object sender, Config args)
        {
            if (myEvent != null)
            {
                myEvent(this, args);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            updateConfig();
            onMyEvent(this,config);
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.tbFAName.Text="";
            this.tbIP.Text="";
            this.tbMask.Text="";
            this.tbGateway.Text="";
            this.tbDNS1.Text="";
            this.tbDNS2.Text="";
        }
    }
}
