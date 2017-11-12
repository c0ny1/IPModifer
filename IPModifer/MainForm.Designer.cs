namespace IPModifer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbNetworkInterface = new System.Windows.Forms.ComboBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNS01 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDNS02 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSave = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolOption = new System.Windows.Forms.ToolStripButton();
            this.tsbLog = new System.Windows.Forms.ToolStripButton();
            this.tsbTray = new System.Windows.Forms.ToolStripButton();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNetworkInterfaceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNewDNS2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNewDNS1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNewGateway = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNewMask = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNewIp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFanAn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "网卡名称";
            // 
            // cbNetworkInterface
            // 
            this.cbNetworkInterface.FormattingEnabled = true;
            this.cbNetworkInterface.Location = new System.Drawing.Point(62, 25);
            this.cbNetworkInterface.Name = "cbNetworkInterface";
            this.cbNetworkInterface.Size = new System.Drawing.Size(292, 20);
            this.cbNetworkInterface.TabIndex = 2;
            this.cbNetworkInterface.SelectedIndexChanged += new System.EventHandler(this.cbNetworkInterface_SelectedIndexChanged);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(360, 25);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(47, 22);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "刷新";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP 地址";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(70, 128);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(124, 21);
            this.tbIp.TabIndex = 5;
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(72, 195);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(121, 21);
            this.tbMask.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "子网掩码";
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(70, 161);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(124, 21);
            this.tbGateway.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "默认网关";
            // 
            // tbDNS01
            // 
            this.tbDNS01.Location = new System.Drawing.Point(69, 222);
            this.tbDNS01.Name = "tbDNS01";
            this.tbDNS01.Size = new System.Drawing.Size(124, 21);
            this.tbDNS01.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "首选DNS";
            // 
            // tbDNS02
            // 
            this.tbDNS02.Location = new System.Drawing.Point(70, 249);
            this.tbDNS02.Name = "tbDNS02";
            this.tbDNS02.Size = new System.Drawing.Size(123, 21);
            this.tbDNS02.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "备用DNS";
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(360, 51);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(47, 21);
            this.tbSave.TabIndex = 14;
            this.tbSave.Text = "修改";
            this.tbSave.UseVisualStyleBackColor = true;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(69, 99);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(124, 21);
            this.tbName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "名称";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolOption,
            this.tsbLog,
            this.tsbTray,
            this.toolAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(418, 25);
            this.toolStrip.TabIndex = 19;
            this.toolStrip.Text = "toolStrip";
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "toolRefresh";
            this.tsbExit.ToolTipText = "退出程序";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // toolOption
            // 
            this.toolOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOption.Image = ((System.Drawing.Image)(resources.GetObject("toolOption.Image")));
            this.toolOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOption.Name = "toolOption";
            this.toolOption.Size = new System.Drawing.Size(23, 22);
            this.toolOption.Text = "toolStripButton2";
            this.toolOption.ToolTipText = "配置";
            this.toolOption.Click += new System.EventHandler(this.toolOption_Click);
            // 
            // tsbLog
            // 
            this.tsbLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbLog.Image")));
            this.tsbLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLog.Name = "tsbLog";
            this.tsbLog.Size = new System.Drawing.Size(23, 22);
            this.tsbLog.Text = "toolStripButton3";
            this.tsbLog.ToolTipText = "显示日志";
            this.tsbLog.Click += new System.EventHandler(this.tsbLog_Click);
            // 
            // tsbTray
            // 
            this.tsbTray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTray.Image = ((System.Drawing.Image)(resources.GetObject("tsbTray.Image")));
            this.tsbTray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTray.Name = "tsbTray";
            this.tsbTray.Size = new System.Drawing.Size(23, 22);
            this.tsbTray.Text = "缩至托盘";
            this.tsbTray.Click += new System.EventHandler(this.tsbTray_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(23, 22);
            this.toolAbout.Text = "关于程序";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "网卡编号";
            // 
            // tbNetworkInterfaceID
            // 
            this.tbNetworkInterfaceID.Location = new System.Drawing.Point(62, 51);
            this.tbNetworkInterfaceID.Name = "tbNetworkInterfaceID";
            this.tbNetworkInterfaceID.ReadOnly = true;
            this.tbNetworkInterfaceID.Size = new System.Drawing.Size(292, 21);
            this.tbNetworkInterfaceID.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "方案";
            // 
            // tbNewDNS2
            // 
            this.tbNewDNS2.Location = new System.Drawing.Point(278, 248);
            this.tbNewDNS2.Name = "tbNewDNS2";
            this.tbNewDNS2.Size = new System.Drawing.Size(124, 21);
            this.tbNewDNS2.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "备用DNS";
            // 
            // tbNewDNS1
            // 
            this.tbNewDNS1.Location = new System.Drawing.Point(277, 221);
            this.tbNewDNS1.Name = "tbNewDNS1";
            this.tbNewDNS1.Size = new System.Drawing.Size(124, 21);
            this.tbNewDNS1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "首选DNS";
            // 
            // tbNewGateway
            // 
            this.tbNewGateway.Location = new System.Drawing.Point(278, 160);
            this.tbNewGateway.Name = "tbNewGateway";
            this.tbNewGateway.Size = new System.Drawing.Size(124, 21);
            this.tbNewGateway.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "默认网关";
            // 
            // tbNewMask
            // 
            this.tbNewMask.Location = new System.Drawing.Point(277, 194);
            this.tbNewMask.Name = "tbNewMask";
            this.tbNewMask.Size = new System.Drawing.Size(124, 21);
            this.tbNewMask.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "子网掩码";
            // 
            // tbNewIp
            // 
            this.tbNewIp.Location = new System.Drawing.Point(278, 127);
            this.tbNewIp.Name = "tbNewIp";
            this.tbNewIp.Size = new System.Drawing.Size(124, 21);
            this.tbNewIp.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "IP 地址";
            // 
            // cbFanAn
            // 
            this.cbFanAn.FormattingEnabled = true;
            this.cbFanAn.Location = new System.Drawing.Point(278, 101);
            this.cbFanAn.Name = "cbFanAn";
            this.cbFanAn.Size = new System.Drawing.Size(124, 20);
            this.cbFanAn.TabIndex = 33;
            this.cbFanAn.SelectedIndexChanged += new System.EventHandler(this.cbFanAn_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 206);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网卡信息";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(213, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 206);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改信息";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(6, 290);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(406, 78);
            this.tbLog.TabIndex = 37;
            this.tbLog.Text = "[log]";
            this.tbLog.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "托盘";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 287);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.cbFanAn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNewDNS2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbNewDNS1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNewGateway);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNewMask);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbNewIp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbNetworkInterfaceID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbDNS02);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDNS01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGateway);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.cbNetworkInterface);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "IPModifer v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNetworkInterface;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDNS01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDNS02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton toolOption;
        private System.Windows.Forms.ToolStripButton tsbLog;
        private System.Windows.Forms.ToolStripButton toolAbout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNetworkInterfaceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNewDNS2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNewDNS1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNewGateway;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNewMask;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbNewIp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbFanAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ToolStripButton tsbTray;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

