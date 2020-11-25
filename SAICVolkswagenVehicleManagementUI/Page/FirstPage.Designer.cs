namespace SAICVolkswagenVehicleManagementUI.Page
{
    partial class FirstPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_CaiDan = new System.Windows.Forms.LinkLabel();
            this.link_TuiChu = new System.Windows.Forms.LinkLabel();
            this.link_PutPwd = new System.Windows.Forms.LinkLabel();
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.lab_NowDateTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NowDateTimer = new System.Windows.Forms.Timer(this.components);
            this.Menu_treeView = new System.Windows.Forms.TreeView();
            this.datagrid_UserInfo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_UserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.link_CaiDan);
            this.panel1.Controls.Add(this.link_TuiChu);
            this.panel1.Controls.Add(this.link_PutPwd);
            this.panel1.Controls.Add(this.link_Back);
            this.panel1.Controls.Add(this.lab_NowDateTimer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            // 
            // link_CaiDan
            // 
            this.link_CaiDan.AutoSize = true;
            this.link_CaiDan.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_CaiDan.LinkColor = System.Drawing.Color.White;
            this.link_CaiDan.Location = new System.Drawing.Point(733, 19);
            this.link_CaiDan.Name = "link_CaiDan";
            this.link_CaiDan.Size = new System.Drawing.Size(53, 12);
            this.link_CaiDan.TabIndex = 6;
            this.link_CaiDan.TabStop = true;
            this.link_CaiDan.Text = "菜单隐藏";
            // 
            // link_TuiChu
            // 
            this.link_TuiChu.AutoSize = true;
            this.link_TuiChu.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_TuiChu.LinkColor = System.Drawing.Color.White;
            this.link_TuiChu.Location = new System.Drawing.Point(675, 19);
            this.link_TuiChu.Name = "link_TuiChu";
            this.link_TuiChu.Size = new System.Drawing.Size(53, 12);
            this.link_TuiChu.TabIndex = 5;
            this.link_TuiChu.TabStop = true;
            this.link_TuiChu.Text = "退出系统";
            this.link_TuiChu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_TuiChu_LinkClicked);
            // 
            // link_PutPwd
            // 
            this.link_PutPwd.AutoSize = true;
            this.link_PutPwd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_PutPwd.LinkColor = System.Drawing.Color.White;
            this.link_PutPwd.Location = new System.Drawing.Point(617, 19);
            this.link_PutPwd.Name = "link_PutPwd";
            this.link_PutPwd.Size = new System.Drawing.Size(53, 12);
            this.link_PutPwd.TabIndex = 4;
            this.link_PutPwd.TabStop = true;
            this.link_PutPwd.Text = "修改密码";
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_Back.LinkColor = System.Drawing.Color.White;
            this.link_Back.Location = new System.Drawing.Point(561, 19);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(53, 12);
            this.link_Back.TabIndex = 3;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "返回主页";
            // 
            // lab_NowDateTimer
            // 
            this.lab_NowDateTimer.AutoSize = true;
            this.lab_NowDateTimer.Location = new System.Drawing.Point(264, 19);
            this.lab_NowDateTimer.Name = "lab_NowDateTimer";
            this.lab_NowDateTimer.Size = new System.Drawing.Size(269, 12);
            this.lab_NowDateTimer.TabIndex = 2;
            this.lab_NowDateTimer.Text = "欢迎admin登录，今天是：2020年11月10日 星期二";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "整 车 试 验 管 理 系 统";
            // 
            // NowDateTimer
            // 
            this.NowDateTimer.Tick += new System.EventHandler(this.NowDateTimer_Tick);
            // 
            // Menu_treeView
            // 
            this.Menu_treeView.BackColor = System.Drawing.Color.SkyBlue;
            this.Menu_treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Menu_treeView.ItemHeight = 20;
            this.Menu_treeView.Location = new System.Drawing.Point(0, 49);
            this.Menu_treeView.Name = "Menu_treeView";
            this.Menu_treeView.Size = new System.Drawing.Size(121, 401);
            this.Menu_treeView.TabIndex = 1;
            // 
            // datagrid_UserInfo
            // 
            this.datagrid_UserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_UserInfo.Location = new System.Drawing.Point(118, 49);
            this.datagrid_UserInfo.Name = "datagrid_UserInfo";
            this.datagrid_UserInfo.RowTemplate.Height = 23;
            this.datagrid_UserInfo.Size = new System.Drawing.Size(682, 401);
            this.datagrid_UserInfo.TabIndex = 2;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagrid_UserInfo);
            this.Controls.Add(this.Menu_treeView);
            this.Controls.Add(this.panel1);
            this.Name = "FirstPage";
            this.Text = "上汽大众道路试验数字化管理平台";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_UserInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_NowDateTimer;
        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.LinkLabel link_CaiDan;
        private System.Windows.Forms.LinkLabel link_TuiChu;
        private System.Windows.Forms.LinkLabel link_PutPwd;
        private System.Windows.Forms.Timer NowDateTimer;
        private System.Windows.Forms.TreeView Menu_treeView;
        private System.Windows.Forms.DataGridView datagrid_UserInfo;
    }
}