namespace SAICVolkswagenVehicleManagementUI.Page
{
    partial class LoginPage
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
            this.DateTimeNow = new System.Windows.Forms.Label();
            this.NowDateTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lab_User = new System.Windows.Forms.Label();
            this.lab_PassWord = new System.Windows.Forms.Label();
            this.lab_VerificationCode = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_VerificationCode = new System.Windows.Forms.TextBox();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.link_ReLoad = new System.Windows.Forms.LinkLabel();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.loginCheckBoxIs = new System.Windows.Forms.CheckBox();
            this.loginCheckBoxUne = new System.Windows.Forms.CheckBox();
            this.link_UpdatePassWord = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimeNow
            // 
            this.DateTimeNow.AutoSize = true;
            this.DateTimeNow.Location = new System.Drawing.Point(443, 429);
            this.DateTimeNow.Name = "DateTimeNow";
            this.DateTimeNow.Size = new System.Drawing.Size(41, 12);
            this.DateTimeNow.TabIndex = 0;
            this.DateTimeNow.Text = "label1";
            // 
            // NowDateTimer
            // 
            this.NowDateTimer.Enabled = true;
            this.NowDateTimer.Interval = 1000;
            this.NowDateTimer.Tick += new System.EventHandler(this.NowDateTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(213, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "上汽大众道路试验管理系统";
            // 
            // lab_User
            // 
            this.lab_User.AutoSize = true;
            this.lab_User.BackColor = System.Drawing.Color.Transparent;
            this.lab_User.Location = new System.Drawing.Point(278, 131);
            this.lab_User.Name = "lab_User";
            this.lab_User.Size = new System.Drawing.Size(65, 12);
            this.lab_User.TabIndex = 2;
            this.lab_User.Text = "登录用户：";
            // 
            // lab_PassWord
            // 
            this.lab_PassWord.AutoSize = true;
            this.lab_PassWord.BackColor = System.Drawing.Color.Transparent;
            this.lab_PassWord.Location = new System.Drawing.Point(278, 171);
            this.lab_PassWord.Name = "lab_PassWord";
            this.lab_PassWord.Size = new System.Drawing.Size(65, 12);
            this.lab_PassWord.TabIndex = 2;
            this.lab_PassWord.Text = "登录密码：";
            // 
            // lab_VerificationCode
            // 
            this.lab_VerificationCode.AutoSize = true;
            this.lab_VerificationCode.BackColor = System.Drawing.Color.Transparent;
            this.lab_VerificationCode.Location = new System.Drawing.Point(278, 208);
            this.lab_VerificationCode.Name = "lab_VerificationCode";
            this.lab_VerificationCode.Size = new System.Drawing.Size(65, 12);
            this.lab_VerificationCode.TabIndex = 2;
            this.lab_VerificationCode.Text = "验 证 码：";
            // 
            // txt_User
            // 
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Location = new System.Drawing.Point(375, 126);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(100, 20);
            this.txt_User.TabIndex = 3;
            // 
            // txt_VerificationCode
            // 
            this.txt_VerificationCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_VerificationCode.Location = new System.Drawing.Point(375, 205);
            this.txt_VerificationCode.Multiline = true;
            this.txt_VerificationCode.Name = "txt_VerificationCode";
            this.txt_VerificationCode.Size = new System.Drawing.Size(100, 21);
            this.txt_VerificationCode.TabIndex = 3;
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.Transparent;
            this.Pic.Location = new System.Drawing.Point(481, 200);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(120, 30);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 4;
            this.Pic.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(280, 298);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Red;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(445, 298);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // link_ReLoad
            // 
            this.link_ReLoad.AutoSize = true;
            this.link_ReLoad.BackColor = System.Drawing.Color.Transparent;
            this.link_ReLoad.Location = new System.Drawing.Point(607, 218);
            this.link_ReLoad.Name = "link_ReLoad";
            this.link_ReLoad.Size = new System.Drawing.Size(89, 12);
            this.link_ReLoad.TabIndex = 6;
            this.link_ReLoad.TabStop = true;
            this.link_ReLoad.Text = "看不清，换一张";
            this.link_ReLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ReLoad_LinkClicked);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PassWord.Location = new System.Drawing.Point(375, 166);
            this.txt_PassWord.Multiline = true;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(100, 21);
            this.txt_PassWord.TabIndex = 3;
            // 
            // loginCheckBoxIs
            // 
            this.loginCheckBoxIs.AutoSize = true;
            this.loginCheckBoxIs.BackColor = System.Drawing.Color.Transparent;
            this.loginCheckBoxIs.Location = new System.Drawing.Point(466, 256);
            this.loginCheckBoxIs.Name = "loginCheckBoxIs";
            this.loginCheckBoxIs.Size = new System.Drawing.Size(72, 16);
            this.loginCheckBoxIs.TabIndex = 7;
            this.loginCheckBoxIs.Text = "自动登录";
            this.loginCheckBoxIs.UseVisualStyleBackColor = false;
            // 
            // loginCheckBoxUne
            // 
            this.loginCheckBoxUne.AutoSize = true;
            this.loginCheckBoxUne.BackColor = System.Drawing.Color.Transparent;
            this.loginCheckBoxUne.Location = new System.Drawing.Point(299, 256);
            this.loginCheckBoxUne.Name = "loginCheckBoxUne";
            this.loginCheckBoxUne.Size = new System.Drawing.Size(72, 16);
            this.loginCheckBoxUne.TabIndex = 8;
            this.loginCheckBoxUne.Text = "记住密码";
            this.loginCheckBoxUne.UseVisualStyleBackColor = false;
            // 
            // link_UpdatePassWord
            // 
            this.link_UpdatePassWord.AutoSize = true;
            this.link_UpdatePassWord.BackColor = System.Drawing.Color.Transparent;
            this.link_UpdatePassWord.ForeColor = System.Drawing.Color.Black;
            this.link_UpdatePassWord.Location = new System.Drawing.Point(482, 174);
            this.link_UpdatePassWord.Name = "link_UpdatePassWord";
            this.link_UpdatePassWord.Size = new System.Drawing.Size(53, 12);
            this.link_UpdatePassWord.TabIndex = 9;
            this.link_UpdatePassWord.TabStop = true;
            this.link_UpdatePassWord.Text = "修改密码";
            this.link_UpdatePassWord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_UpdatePassWord_LinkClicked);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_UpdatePassWord);
            this.Controls.Add(this.loginCheckBoxUne);
            this.Controls.Add(this.loginCheckBoxIs);
            this.Controls.Add(this.link_ReLoad);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.txt_VerificationCode);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lab_VerificationCode);
            this.Controls.Add(this.lab_PassWord);
            this.Controls.Add(this.lab_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimeNow);
            this.Name = "LoginPage";
            this.Text = "上汽大众道路试验数字化管理平台";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Shown += new System.EventHandler(this.LoginPage_Shown);
            this.SizeChanged += new System.EventHandler(this.LoginPage_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateTimeNow;
        private System.Windows.Forms.Timer NowDateTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_User;
        private System.Windows.Forms.Label lab_PassWord;
        private System.Windows.Forms.Label lab_VerificationCode;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_VerificationCode;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.LinkLabel link_ReLoad;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.CheckBox loginCheckBoxIs;
        private System.Windows.Forms.CheckBox loginCheckBoxUne;
        private System.Windows.Forms.LinkLabel link_UpdatePassWord;
    }
}