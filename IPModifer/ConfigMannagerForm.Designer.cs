namespace IPModifer
{
    partial class ConfigMannagerForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvFanAn = new System.Windows.Forms.DataGridView();
            this.cmFanAn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmModify = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gateway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dns1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dns2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanAn)).BeginInit();
            this.cmFanAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFanAn
            // 
            this.dgvFanAn.AllowUserToOrderColumns = true;
            this.dgvFanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.ip,
            this.mask,
            this.gateway,
            this.dns1,
            this.dns2,
            this.end_time});
            this.dgvFanAn.ContextMenuStrip = this.cmFanAn;
            this.dgvFanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFanAn.Location = new System.Drawing.Point(0, 0);
            this.dgvFanAn.MultiSelect = false;
            this.dgvFanAn.Name = "dgvFanAn";
            this.dgvFanAn.RowTemplate.Height = 23;
            this.dgvFanAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFanAn.Size = new System.Drawing.Size(742, 352);
            this.dgvFanAn.TabIndex = 2;
            // 
            // cmFanAn
            // 
            this.cmFanAn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmAdd,
            this.cmDel,
            this.cmModify,
            this.cmRefresh});
            this.cmFanAn.Name = "cmFanAn";
            this.cmFanAn.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmFanAn.ShowImageMargin = false;
            this.cmFanAn.Size = new System.Drawing.Size(100, 92);
            // 
            // cmAdd
            // 
            this.cmAdd.Name = "cmAdd";
            this.cmAdd.Size = new System.Drawing.Size(99, 22);
            this.cmAdd.Text = "添加方案";
            this.cmAdd.Click += new System.EventHandler(this.cmAdd_Click);
            // 
            // cmDel
            // 
            this.cmDel.Name = "cmDel";
            this.cmDel.Size = new System.Drawing.Size(99, 22);
            this.cmDel.Text = "删除方案";
            this.cmDel.Click += new System.EventHandler(this.cmDel_Click);
            // 
            // cmModify
            // 
            this.cmModify.Name = "cmModify";
            this.cmModify.Size = new System.Drawing.Size(99, 22);
            this.cmModify.Text = "修改方案";
            this.cmModify.Click += new System.EventHandler(this.cmModify_Click);
            // 
            // cmRefresh
            // 
            this.cmRefresh.Name = "cmRefresh";
            this.cmRefresh.Size = new System.Drawing.Size(99, 22);
            this.cmRefresh.Text = "刷新方案";
            this.cmRefresh.Click += new System.EventHandler(this.cmRefresh_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "方案名称";
            this.name.Name = "name";
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "ip地址";
            this.ip.Name = "ip";
            // 
            // mask
            // 
            this.mask.DataPropertyName = "mask";
            this.mask.HeaderText = "子网掩码";
            this.mask.Name = "mask";
            // 
            // gateway
            // 
            this.gateway.DataPropertyName = "gateway";
            this.gateway.HeaderText = "默认网关";
            this.gateway.Name = "gateway";
            // 
            // dns1
            // 
            this.dns1.DataPropertyName = "DNS1";
            this.dns1.HeaderText = "首选DNS";
            this.dns1.Name = "dns1";
            // 
            // dns2
            // 
            this.dns2.DataPropertyName = "DNS2";
            this.dns2.HeaderText = "备用DNS";
            this.dns2.Name = "dns2";
            // 
            // end_time
            // 
            this.end_time.DataPropertyName = "end_time";
            this.end_time.HeaderText = "创建时间";
            this.end_time.Name = "end_time";
            // 
            // fanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 352);
            this.Controls.Add(this.dgvFanAn);
            this.Name = "fanganForm";
            this.Text = "方案";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanAn)).EndInit();
            this.cmFanAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFanAn;
        private System.Windows.Forms.ContextMenuStrip cmFanAn;
        private System.Windows.Forms.ToolStripMenuItem cmAdd;
        private System.Windows.Forms.ToolStripMenuItem cmDel;
        private System.Windows.Forms.ToolStripMenuItem cmModify;
        private System.Windows.Forms.ToolStripMenuItem cmRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn gateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn dns1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dns2;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
    }
}