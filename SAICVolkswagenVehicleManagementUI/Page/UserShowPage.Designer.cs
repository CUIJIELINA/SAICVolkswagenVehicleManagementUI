namespace SAICVolkswagenVehicleManagementUI.Page
{
    partial class UserShowPage
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
            this.datagrid_UserInfo = new System.Windows.Forms.DataGridView();
            this.select_name = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.cmb_depart = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_UserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_UserInfo
            // 
            this.datagrid_UserInfo.AllowUserToAddRows = false;
            this.datagrid_UserInfo.AllowUserToDeleteRows = false;
            this.datagrid_UserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_UserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.UserSex,
            this.UserPassWord,
            this.DepartmentName,
            this.E_Mail,
            this.RoleName});
            this.datagrid_UserInfo.Location = new System.Drawing.Point(0, 48);
            this.datagrid_UserInfo.Name = "datagrid_UserInfo";
            this.datagrid_UserInfo.ReadOnly = true;
            this.datagrid_UserInfo.RowTemplate.Height = 23;
            this.datagrid_UserInfo.Size = new System.Drawing.Size(1066, 535);
            this.datagrid_UserInfo.TabIndex = 0;
            this.datagrid_UserInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagrid_UserInfo_RowsAdded);
            // 
            // select_name
            // 
            this.select_name.Location = new System.Drawing.Point(13, 13);
            this.select_name.Name = "select_name";
            this.select_name.Size = new System.Drawing.Size(100, 21);
            this.select_name.TabIndex = 1;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(395, 12);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cmb_Department
            // 
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(120, 15);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(134, 20);
            this.cmb_Department.TabIndex = 3;
            this.cmb_Department.SelectedIndexChanged += new System.EventHandler(this.cmb_Department_SelectedIndexChanged);
            // 
            // cmb_depart
            // 
            this.cmb_depart.FormattingEnabled = true;
            this.cmb_depart.Location = new System.Drawing.Point(260, 15);
            this.cmb_depart.Name = "cmb_depart";
            this.cmb_depart.Size = new System.Drawing.Size(129, 20);
            this.cmb_depart.TabIndex = 4;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "员工名称";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserSex
            // 
            this.UserSex.DataPropertyName = "UserSex";
            this.UserSex.HeaderText = "性别";
            this.UserSex.Name = "UserSex";
            this.UserSex.ReadOnly = true;
            // 
            // UserPassWord
            // 
            this.UserPassWord.DataPropertyName = "UserPassWord";
            this.UserPassWord.HeaderText = "密码";
            this.UserPassWord.Name = "UserPassWord";
            this.UserPassWord.ReadOnly = true;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "部门名称";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            // 
            // E_Mail
            // 
            this.E_Mail.DataPropertyName = "E_Mail";
            this.E_Mail.HeaderText = "邮箱";
            this.E_Mail.Name = "E_Mail";
            this.E_Mail.ReadOnly = true;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "分配角色";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // UserShowPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 584);
            this.Controls.Add(this.cmb_depart);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.select_name);
            this.Controls.Add(this.datagrid_UserInfo);
            this.Name = "UserShowPage";
            this.Text = "道路试验数字化平台";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_UserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_UserInfo;
        private System.Windows.Forms.TextBox select_name;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.ComboBox cmb_depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}