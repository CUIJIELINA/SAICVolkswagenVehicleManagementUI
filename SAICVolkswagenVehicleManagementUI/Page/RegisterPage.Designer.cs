namespace SAICVolkswagenVehicleManagementUI
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lab_VerificationCode = new System.Windows.Forms.Label();
            this.txt_VerificationCode = new System.Windows.Forms.TextBox();
            this.link_VerificationCode = new System.Windows.Forms.LinkLabel();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lab_QQMail = new System.Windows.Forms.Label();
            this.txt_QQMail = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.DateTimeNow = new System.Windows.Forms.Label();
            this.DateTimerNow = new System.Windows.Forms.Timer(this.components);
            this.QQEMail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_UserRemark = new System.Windows.Forms.TextBox();
            this.rab_nan = new System.Windows.Forms.RadioButton();
            this.rab_nv = new System.Windows.Forms.RadioButton();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.date_birthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_BeginPassWord = new System.Windows.Forms.TextBox();
            this.cmb_depart = new System.Windows.Forms.ComboBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_PassWord = new System.Windows.Forms.Label();
            this.lab_BeignPassWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "注册员工信息";
            // 
            // lab_VerificationCode
            // 
            this.lab_VerificationCode.AutoSize = true;
            this.lab_VerificationCode.BackColor = System.Drawing.Color.Transparent;
            this.lab_VerificationCode.Location = new System.Drawing.Point(86, 293);
            this.lab_VerificationCode.Name = "lab_VerificationCode";
            this.lab_VerificationCode.Size = new System.Drawing.Size(65, 12);
            this.lab_VerificationCode.TabIndex = 3;
            this.lab_VerificationCode.Text = "验 证 码：";
            // 
            // txt_VerificationCode
            // 
            this.txt_VerificationCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_VerificationCode.Location = new System.Drawing.Point(157, 288);
            this.txt_VerificationCode.Multiline = true;
            this.txt_VerificationCode.Name = "txt_VerificationCode";
            this.txt_VerificationCode.Size = new System.Drawing.Size(100, 21);
            this.txt_VerificationCode.TabIndex = 4;
            this.txt_VerificationCode.MouseLeave += new System.EventHandler(this.txt_VerificationCode_MouseLeave);
            // 
            // link_VerificationCode
            // 
            this.link_VerificationCode.AutoSize = true;
            this.link_VerificationCode.BackColor = System.Drawing.Color.Transparent;
            this.link_VerificationCode.Location = new System.Drawing.Point(263, 294);
            this.link_VerificationCode.Name = "link_VerificationCode";
            this.link_VerificationCode.Size = new System.Drawing.Size(89, 12);
            this.link_VerificationCode.TabIndex = 7;
            this.link_VerificationCode.TabStop = true;
            this.link_VerificationCode.Text = "获取邮箱验证码";
            this.link_VerificationCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_VerificationCode_LinkClicked);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Red;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(284, 378);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(423, 378);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "取消";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lab_QQMail
            // 
            this.lab_QQMail.AutoSize = true;
            this.lab_QQMail.BackColor = System.Drawing.Color.Transparent;
            this.lab_QQMail.Location = new System.Drawing.Point(74, 261);
            this.lab_QQMail.Name = "lab_QQMail";
            this.lab_QQMail.Size = new System.Drawing.Size(77, 12);
            this.lab_QQMail.TabIndex = 3;
            this.lab_QQMail.Text = "输入QQ邮箱：";
            // 
            // txt_QQMail
            // 
            this.txt_QQMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_QQMail.Location = new System.Drawing.Point(157, 254);
            this.txt_QQMail.Multiline = true;
            this.txt_QQMail.Name = "txt_QQMail";
            this.txt_QQMail.Size = new System.Drawing.Size(100, 21);
            this.txt_QQMail.TabIndex = 4;
            this.txt_QQMail.TextChanged += new System.EventHandler(this.txt_QQMail_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DateTimeNow
            // 
            this.DateTimeNow.AutoSize = true;
            this.DateTimeNow.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeNow.Location = new System.Drawing.Point(457, 429);
            this.DateTimeNow.Name = "DateTimeNow";
            this.DateTimeNow.Size = new System.Drawing.Size(41, 12);
            this.DateTimeNow.TabIndex = 10;
            this.DateTimeNow.Text = "label1";
            // 
            // DateTimerNow
            // 
            this.DateTimerNow.Tick += new System.EventHandler(this.DateTimerNow_Tick);
            // 
            // QQEMail
            // 
            this.QQEMail.AutoSize = true;
            this.QQEMail.BackColor = System.Drawing.Color.Transparent;
            this.QQEMail.ForeColor = System.Drawing.Color.Red;
            this.QQEMail.Location = new System.Drawing.Point(264, 262);
            this.QQEMail.Name = "QQEMail";
            this.QQEMail.Size = new System.Drawing.Size(119, 12);
            this.QQEMail.TabIndex = 11;
            this.QQEMail.Text = "*(请输入有效QQ邮箱)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(110, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "备注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(110, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "生日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(110, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(110, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(110, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "姓名：";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Location = new System.Drawing.Point(157, 76);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Name.TabIndex = 4;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_UserRemark
            // 
            this.txt_UserRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserRemark.Location = new System.Drawing.Point(157, 219);
            this.txt_UserRemark.Multiline = true;
            this.txt_UserRemark.Name = "txt_UserRemark";
            this.txt_UserRemark.Size = new System.Drawing.Size(100, 21);
            this.txt_UserRemark.TabIndex = 4;
            // 
            // rab_nan
            // 
            this.rab_nan.AutoSize = true;
            this.rab_nan.BackColor = System.Drawing.Color.Transparent;
            this.rab_nan.Location = new System.Drawing.Point(157, 115);
            this.rab_nan.Name = "rab_nan";
            this.rab_nan.Size = new System.Drawing.Size(35, 16);
            this.rab_nan.TabIndex = 12;
            this.rab_nan.TabStop = true;
            this.rab_nan.Text = "男";
            this.rab_nan.UseVisualStyleBackColor = false;
            // 
            // rab_nv
            // 
            this.rab_nv.AutoSize = true;
            this.rab_nv.BackColor = System.Drawing.Color.Transparent;
            this.rab_nv.Location = new System.Drawing.Point(222, 116);
            this.rab_nv.Name = "rab_nv";
            this.rab_nv.Size = new System.Drawing.Size(35, 16);
            this.rab_nv.TabIndex = 12;
            this.rab_nv.TabStop = true;
            this.rab_nv.Text = "女";
            this.rab_nv.UseVisualStyleBackColor = false;
            // 
            // cmb_Department
            // 
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "总经理",
            "开发部",
            "电子部",
            "技术部",
            "试车部"});
            this.cmb_Department.Location = new System.Drawing.Point(157, 148);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(144, 20);
            this.cmb_Department.TabIndex = 13;
            this.cmb_Department.SelectedIndexChanged += new System.EventHandler(this.cmb_Department_SelectedIndexChanged);
            // 
            // date_birthday
            // 
            this.date_birthday.Location = new System.Drawing.Point(157, 186);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Size = new System.Drawing.Size(200, 21);
            this.date_birthday.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(497, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "编码：";
            // 
            // txt_Code
            // 
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Code.Location = new System.Drawing.Point(544, 76);
            this.txt_Code.Multiline = true;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(100, 21);
            this.txt_Code.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(497, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(473, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "确认密码：";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PassWord.Location = new System.Drawing.Point(544, 110);
            this.txt_PassWord.Multiline = true;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '*';
            this.txt_PassWord.Size = new System.Drawing.Size(100, 21);
            this.txt_PassWord.TabIndex = 4;
            this.txt_PassWord.TextChanged += new System.EventHandler(this.txt_PassWord_TextChanged);
            // 
            // txt_BeginPassWord
            // 
            this.txt_BeginPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BeginPassWord.Location = new System.Drawing.Point(544, 146);
            this.txt_BeginPassWord.Multiline = true;
            this.txt_BeginPassWord.Name = "txt_BeginPassWord";
            this.txt_BeginPassWord.PasswordChar = '*';
            this.txt_BeginPassWord.Size = new System.Drawing.Size(100, 21);
            this.txt_BeginPassWord.TabIndex = 4;
            this.txt_BeginPassWord.TextChanged += new System.EventHandler(this.txt_BeginPassWord_TextChanged);
            this.txt_BeginPassWord.MouseLeave += new System.EventHandler(this.txt_BeginPassWord_MouseLeave);
            // 
            // cmb_depart
            // 
            this.cmb_depart.FormattingEnabled = true;
            this.cmb_depart.Location = new System.Drawing.Point(307, 148);
            this.cmb_depart.Name = "cmb_depart";
            this.cmb_depart.Size = new System.Drawing.Size(121, 20);
            this.cmb_depart.TabIndex = 15;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.BackColor = System.Drawing.Color.Transparent;
            this.lab_Name.ForeColor = System.Drawing.Color.Red;
            this.lab_Name.Location = new System.Drawing.Point(262, 82);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(11, 12);
            this.lab_Name.TabIndex = 16;
            this.lab_Name.Text = "*";
            // 
            // lab_PassWord
            // 
            this.lab_PassWord.AutoSize = true;
            this.lab_PassWord.BackColor = System.Drawing.Color.Transparent;
            this.lab_PassWord.ForeColor = System.Drawing.Color.Red;
            this.lab_PassWord.Location = new System.Drawing.Point(648, 114);
            this.lab_PassWord.Name = "lab_PassWord";
            this.lab_PassWord.Size = new System.Drawing.Size(11, 12);
            this.lab_PassWord.TabIndex = 17;
            this.lab_PassWord.Text = "*";
            // 
            // lab_BeignPassWord
            // 
            this.lab_BeignPassWord.AutoSize = true;
            this.lab_BeignPassWord.BackColor = System.Drawing.Color.Transparent;
            this.lab_BeignPassWord.ForeColor = System.Drawing.Color.Red;
            this.lab_BeignPassWord.Location = new System.Drawing.Point(648, 151);
            this.lab_BeignPassWord.Name = "lab_BeignPassWord";
            this.lab_BeignPassWord.Size = new System.Drawing.Size(11, 12);
            this.lab_BeignPassWord.TabIndex = 18;
            this.lab_BeignPassWord.Text = "*";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_BeignPassWord);
            this.Controls.Add(this.lab_PassWord);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.cmb_depart);
            this.Controls.Add(this.date_birthday);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.rab_nv);
            this.Controls.Add(this.rab_nan);
            this.Controls.Add(this.QQEMail);
            this.Controls.Add(this.DateTimeNow);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.link_VerificationCode);
            this.Controls.Add(this.txt_BeginPassWord);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_UserRemark);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_QQMail);
            this.Controls.Add(this.txt_VerificationCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_QQMail);
            this.Controls.Add(this.lab_VerificationCode);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "上汽大众道路试验数字化管理平台";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_VerificationCode;
        private System.Windows.Forms.TextBox txt_VerificationCode;
        private System.Windows.Forms.LinkLabel link_VerificationCode;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lab_QQMail;
        private System.Windows.Forms.TextBox txt_QQMail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label DateTimeNow;
        private System.Windows.Forms.Timer DateTimerNow;
        private System.Windows.Forms.Label QQEMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_UserRemark;
        private System.Windows.Forms.RadioButton rab_nan;
        private System.Windows.Forms.RadioButton rab_nv;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.DateTimePicker date_birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_BeginPassWord;
        private System.Windows.Forms.ComboBox cmb_depart;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_PassWord;
        private System.Windows.Forms.Label lab_BeignPassWord;
    }
}

