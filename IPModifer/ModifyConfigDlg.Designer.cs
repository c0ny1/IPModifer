namespace IPModifer
{
    partial class ModifyConfigDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDNS2 = new System.Windows.Forms.TextBox();
            this.tbDNS1 = new System.Windows.Forms.TextBox();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbFAName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDNS2
            // 
            this.tbDNS2.Location = new System.Drawing.Point(79, 201);
            this.tbDNS2.Name = "tbDNS2";
            this.tbDNS2.Size = new System.Drawing.Size(157, 21);
            this.tbDNS2.TabIndex = 27;
            // 
            // tbDNS1
            // 
            this.tbDNS1.Location = new System.Drawing.Point(79, 169);
            this.tbDNS1.Name = "tbDNS1";
            this.tbDNS1.Size = new System.Drawing.Size(157, 21);
            this.tbDNS1.TabIndex = 26;
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(79, 136);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(157, 21);
            this.tbGateway.TabIndex = 25;
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(79, 100);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(157, 21);
            this.tbMask.TabIndex = 24;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(79, 70);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(157, 21);
            this.tbIP.TabIndex = 23;
            // 
            // tbFAName
            // 
            this.tbFAName.Location = new System.Drawing.Point(79, 35);
            this.tbFAName.Name = "tbFAName";
            this.tbFAName.Size = new System.Drawing.Size(157, 21);
            this.tbFAName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "备用DNS：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "首选DNS：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "默认网关：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "子网掩码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "方案名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP 地址：";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(163, 234);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(12, 234);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 14;
            this.btModify.Text = "修改";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(79, 6);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(157, 21);
            this.tbID.TabIndex = 29;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(88, 234);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 30;
            this.btReset.Text = "重置";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // ModifyConfigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 263);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDNS2);
            this.Controls.Add(this.tbDNS1);
            this.Controls.Add(this.tbGateway);
            this.Controls.Add(this.tbMask);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbFAName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyConfigDlg";
            this.Text = "修改方案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbDNS2;
        public System.Windows.Forms.TextBox tbDNS1;
        public System.Windows.Forms.TextBox tbGateway;
        public System.Windows.Forms.TextBox tbMask;
        public System.Windows.Forms.TextBox tbIP;
        public System.Windows.Forms.TextBox tbFAName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btReset;
    }
}