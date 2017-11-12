namespace IPModifer
{
    partial class AddConfigDlg
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
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFAName = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.tbDNS1 = new System.Windows.Forms.TextBox();
            this.tbDNS2 = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(9, 209);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(76, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP 地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "方案名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "子网掩码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "默认网关：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "首选DNS：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "备用DNS：";
            // 
            // tbFAName
            // 
            this.tbFAName.Location = new System.Drawing.Point(81, 10);
            this.tbFAName.Name = "tbFAName";
            this.tbFAName.Size = new System.Drawing.Size(157, 21);
            this.tbFAName.TabIndex = 8;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(81, 45);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(157, 21);
            this.tbIP.TabIndex = 9;
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(81, 75);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(157, 21);
            this.tbMask.TabIndex = 10;
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(81, 111);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(157, 21);
            this.tbGateway.TabIndex = 11;
            // 
            // tbDNS1
            // 
            this.tbDNS1.Location = new System.Drawing.Point(81, 144);
            this.tbDNS1.Name = "tbDNS1";
            this.tbDNS1.Size = new System.Drawing.Size(157, 21);
            this.tbDNS1.TabIndex = 12;
            // 
            // tbDNS2
            // 
            this.tbDNS2.Location = new System.Drawing.Point(81, 176);
            this.tbDNS2.Name = "tbDNS2";
            this.tbDNS2.Size = new System.Drawing.Size(157, 21);
            this.tbDNS2.TabIndex = 13;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(166, 209);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(76, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(87, 209);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(76, 23);
            this.btReset.TabIndex = 14;
            this.btReset.Text = "重置";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // AddConfigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 241);
            this.Controls.Add(this.btReset);
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
            this.Controls.Add(this.btAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddConfigDlg";
            this.Text = "添加方案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFAName;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.TextBox tbDNS1;
        private System.Windows.Forms.TextBox tbDNS2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btReset;
    }
}