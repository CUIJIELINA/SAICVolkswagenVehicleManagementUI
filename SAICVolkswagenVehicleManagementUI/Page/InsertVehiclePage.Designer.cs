namespace SAICVolkswagenVehicleManagementUI.Page
{
    partial class InsertVehiclePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_VehicleNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_VDSNumber = new System.Windows.Forms.TextBox();
            this.cmb_Ability = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(435, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "添加车辆信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "车号：";
            // 
            // txt_VehicleNumber
            // 
            this.txt_VehicleNumber.Location = new System.Drawing.Point(291, 102);
            this.txt_VehicleNumber.Name = "txt_VehicleNumber";
            this.txt_VehicleNumber.Size = new System.Drawing.Size(100, 21);
            this.txt_VehicleNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "VDS号：";
            // 
            // txt_VDSNumber
            // 
            this.txt_VDSNumber.Location = new System.Drawing.Point(291, 138);
            this.txt_VDSNumber.Name = "txt_VDSNumber";
            this.txt_VDSNumber.Size = new System.Drawing.Size(100, 21);
            this.txt_VDSNumber.TabIndex = 5;
            // 
            // cmb_Ability
            // 
            this.cmb_Ability.FormattingEnabled = true;
            this.cmb_Ability.Location = new System.Drawing.Point(291, 177);
            this.cmb_Ability.Name = "cmb_Ability";
            this.cmb_Ability.Size = new System.Drawing.Size(121, 20);
            this.cmb_Ability.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "能力：";
            // 
            // InsertVehiclePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 584);
            this.Controls.Add(this.cmb_Ability);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_VDSNumber);
            this.Controls.Add(this.txt_VehicleNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertVehiclePage";
            this.Text = "道路试验数字化平台";
            this.Load += new System.EventHandler(this.InsertVehiclePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_VehicleNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_VDSNumber;
        private System.Windows.Forms.ComboBox cmb_Ability;
        private System.Windows.Forms.Label label4;
    }
}