namespace SAICVolkswagenVehicleManagementUI.Page
{
    partial class UpdatePassWordPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lab_VerificationCode = new System.Windows.Forms.Label();
            this.lab_PassWord = new System.Windows.Forms.Label();
            this.lab_User = new System.Windows.Forms.Label();
            this.btn_EditPassWord = new System.Windows.Forms.Button();
            this.txt_oldPassWord = new System.Windows.Forms.TextBox();
            this.lab_UserID = new System.Windows.Forms.Label();
            this.txt_newPassWord = new System.Windows.Forms.TextBox();
            this.txt_beginPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(332, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "修改密码";
            // 
            // lab_VerificationCode
            // 
            this.lab_VerificationCode.AutoSize = true;
            this.lab_VerificationCode.BackColor = System.Drawing.Color.Transparent;
            this.lab_VerificationCode.Location = new System.Drawing.Point(267, 214);
            this.lab_VerificationCode.Name = "lab_VerificationCode";
            this.lab_VerificationCode.Size = new System.Drawing.Size(65, 12);
            this.lab_VerificationCode.TabIndex = 4;
            this.lab_VerificationCode.Text = "确认密码：";
            // 
            // lab_PassWord
            // 
            this.lab_PassWord.AutoSize = true;
            this.lab_PassWord.BackColor = System.Drawing.Color.Transparent;
            this.lab_PassWord.Location = new System.Drawing.Point(279, 177);
            this.lab_PassWord.Name = "lab_PassWord";
            this.lab_PassWord.Size = new System.Drawing.Size(53, 12);
            this.lab_PassWord.TabIndex = 5;
            this.lab_PassWord.Text = "新密码：";
            // 
            // lab_User
            // 
            this.lab_User.AutoSize = true;
            this.lab_User.BackColor = System.Drawing.Color.Transparent;
            this.lab_User.Location = new System.Drawing.Point(279, 137);
            this.lab_User.Name = "lab_User";
            this.lab_User.Size = new System.Drawing.Size(53, 12);
            this.lab_User.TabIndex = 6;
            this.lab_User.Text = "旧密码：";
            // 
            // btn_EditPassWord
            // 
            this.btn_EditPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_EditPassWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditPassWord.ForeColor = System.Drawing.Color.White;
            this.btn_EditPassWord.Location = new System.Drawing.Point(361, 272);
            this.btn_EditPassWord.Name = "btn_EditPassWord";
            this.btn_EditPassWord.Size = new System.Drawing.Size(75, 23);
            this.btn_EditPassWord.TabIndex = 7;
            this.btn_EditPassWord.Text = "修改";
            this.btn_EditPassWord.UseVisualStyleBackColor = false;
            this.btn_EditPassWord.Click += new System.EventHandler(this.btn_EditPassWord_Click);
            // 
            // txt_oldPassWord
            // 
            this.txt_oldPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_oldPassWord.Location = new System.Drawing.Point(338, 132);
            this.txt_oldPassWord.Name = "txt_oldPassWord";
            this.txt_oldPassWord.Size = new System.Drawing.Size(152, 14);
            this.txt_oldPassWord.TabIndex = 8;
            // 
            // lab_UserID
            // 
            this.lab_UserID.AutoSize = true;
            this.lab_UserID.Location = new System.Drawing.Point(395, 96);
            this.lab_UserID.Name = "lab_UserID";
            this.lab_UserID.Size = new System.Drawing.Size(41, 12);
            this.lab_UserID.TabIndex = 9;
            this.lab_UserID.Text = "label2";
            // 
            // txt_newPassWord
            // 
            this.txt_newPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPassWord.Location = new System.Drawing.Point(338, 173);
            this.txt_newPassWord.Name = "txt_newPassWord";
            this.txt_newPassWord.Size = new System.Drawing.Size(152, 14);
            this.txt_newPassWord.TabIndex = 10;
            // 
            // txt_beginPassWord
            // 
            this.txt_beginPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_beginPassWord.Location = new System.Drawing.Point(338, 209);
            this.txt_beginPassWord.Name = "txt_beginPassWord";
            this.txt_beginPassWord.Size = new System.Drawing.Size(152, 14);
            this.txt_beginPassWord.TabIndex = 11;
            // 
            // UpdatePassWordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_beginPassWord);
            this.Controls.Add(this.txt_newPassWord);
            this.Controls.Add(this.lab_UserID);
            this.Controls.Add(this.txt_oldPassWord);
            this.Controls.Add(this.btn_EditPassWord);
            this.Controls.Add(this.lab_VerificationCode);
            this.Controls.Add(this.lab_PassWord);
            this.Controls.Add(this.lab_User);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePassWordPage";
            this.Text = "道路试验数字化平台";
            this.Load += new System.EventHandler(this.UpdatePassWordPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_VerificationCode;
        private System.Windows.Forms.Label lab_PassWord;
        private System.Windows.Forms.Label lab_User;
        private System.Windows.Forms.Button btn_EditPassWord;
        private System.Windows.Forms.TextBox txt_oldPassWord;
        private System.Windows.Forms.Label lab_UserID;
        private System.Windows.Forms.TextBox txt_newPassWord;
        private System.Windows.Forms.TextBox txt_beginPassWord;
    }
}