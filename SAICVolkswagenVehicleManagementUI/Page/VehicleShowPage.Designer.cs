namespace SAICVolkswagenVehicleManagementUI.Page
{
    partial class VehicleShowPage
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
            this.datagrid_Vehicles = new System.Windows.Forms.DataGridView();
            this.CarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDSNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverAbilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyreSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MileageToRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_select = new System.Windows.Forms.Button();
            this.cmb_ability = new System.Windows.Forms.ComboBox();
            this.select_CarNumber = new System.Windows.Forms.TextBox();
            this.select_VDSNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_Vehicles
            // 
            this.datagrid_Vehicles.AllowUserToAddRows = false;
            this.datagrid_Vehicles.AllowUserToDeleteRows = false;
            this.datagrid_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Vehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarNumber,
            this.VDSNumber,
            this.ProjectNumber,
            this.CarModel,
            this.DriverAbilityName,
            this.EngineStructure,
            this.EngineNumber,
            this.Transmission,
            this.TyreSize,
            this.Remark,
            this.CurrentMileage,
            this.RemainingMileage,
            this.Odometer,
            this.MileageToRun,
            this.RemainingFrequency,
            this.StateDate,
            this.EndDate});
            this.datagrid_Vehicles.Location = new System.Drawing.Point(0, 66);
            this.datagrid_Vehicles.Name = "datagrid_Vehicles";
            this.datagrid_Vehicles.ReadOnly = true;
            this.datagrid_Vehicles.RowTemplate.Height = 23;
            this.datagrid_Vehicles.Size = new System.Drawing.Size(1066, 518);
            this.datagrid_Vehicles.TabIndex = 0;
            this.datagrid_Vehicles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagrid_Vehicles_RowsAdded);
            // 
            // CarNumber
            // 
            this.CarNumber.DataPropertyName = "CarNumber";
            this.CarNumber.HeaderText = "车号";
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.ReadOnly = true;
            // 
            // VDSNumber
            // 
            this.VDSNumber.DataPropertyName = "VDSNumber";
            this.VDSNumber.HeaderText = "VDS号";
            this.VDSNumber.Name = "VDSNumber";
            this.VDSNumber.ReadOnly = true;
            // 
            // ProjectNumber
            // 
            this.ProjectNumber.DataPropertyName = "ProjectNumber";
            this.ProjectNumber.HeaderText = "项目编号";
            this.ProjectNumber.Name = "ProjectNumber";
            this.ProjectNumber.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.HeaderText = "车型";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // DriverAbilityName
            // 
            this.DriverAbilityName.DataPropertyName = "DriverAbilityName";
            this.DriverAbilityName.HeaderText = "试验类型";
            this.DriverAbilityName.Name = "DriverAbilityName";
            this.DriverAbilityName.ReadOnly = true;
            // 
            // EngineStructure
            // 
            this.EngineStructure.DataPropertyName = "EngineStructure";
            this.EngineStructure.HeaderText = "发动机结构";
            this.EngineStructure.Name = "EngineStructure";
            this.EngineStructure.ReadOnly = true;
            // 
            // EngineNumber
            // 
            this.EngineNumber.DataPropertyName = "EngineNumber";
            this.EngineNumber.HeaderText = "发动机编号";
            this.EngineNumber.Name = "EngineNumber";
            this.EngineNumber.ReadOnly = true;
            // 
            // Transmission
            // 
            this.Transmission.DataPropertyName = "Transmission";
            this.Transmission.HeaderText = "变速箱样式";
            this.Transmission.Name = "Transmission";
            this.Transmission.ReadOnly = true;
            // 
            // TyreSize
            // 
            this.TyreSize.DataPropertyName = "TyreSize";
            this.TyreSize.HeaderText = "轮胎尺寸";
            this.TyreSize.Name = "TyreSize";
            this.TyreSize.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // CurrentMileage
            // 
            this.CurrentMileage.DataPropertyName = "strCurrentMileage";
            this.CurrentMileage.HeaderText = "当前里程";
            this.CurrentMileage.Name = "CurrentMileage";
            this.CurrentMileage.ReadOnly = true;
            // 
            // RemainingMileage
            // 
            this.RemainingMileage.DataPropertyName = "strRemainingMileage";
            this.RemainingMileage.HeaderText = "剩余里程";
            this.RemainingMileage.Name = "RemainingMileage";
            this.RemainingMileage.ReadOnly = true;
            // 
            // Odometer
            // 
            this.Odometer.DataPropertyName = "strOdometer";
            this.Odometer.HeaderText = "里程表里程";
            this.Odometer.Name = "Odometer";
            this.Odometer.ReadOnly = true;
            // 
            // MileageToRun
            // 
            this.MileageToRun.DataPropertyName = "strMileageToRun";
            this.MileageToRun.HeaderText = "应跑里程";
            this.MileageToRun.Name = "MileageToRun";
            this.MileageToRun.ReadOnly = true;
            // 
            // RemainingFrequency
            // 
            this.RemainingFrequency.DataPropertyName = "strRemainingFrequency";
            this.RemainingFrequency.HeaderText = "剩余每周所需班次";
            this.RemainingFrequency.Name = "RemainingFrequency";
            this.RemainingFrequency.ReadOnly = true;
            // 
            // StateDate
            // 
            this.StateDate.DataPropertyName = "StateDate";
            this.StateDate.HeaderText = "开始时间";
            this.StateDate.Name = "StateDate";
            this.StateDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "结束时间";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(907, 24);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cmb_ability
            // 
            this.cmb_ability.FormattingEnabled = true;
            this.cmb_ability.Location = new System.Drawing.Point(306, 23);
            this.cmb_ability.Name = "cmb_ability";
            this.cmb_ability.Size = new System.Drawing.Size(121, 20);
            this.cmb_ability.TabIndex = 2;
            // 
            // select_CarNumber
            // 
            this.select_CarNumber.Location = new System.Drawing.Point(94, 23);
            this.select_CarNumber.Name = "select_CarNumber";
            this.select_CarNumber.Size = new System.Drawing.Size(100, 21);
            this.select_CarNumber.TabIndex = 3;
            // 
            // select_VDSNumber
            // 
            this.select_VDSNumber.Location = new System.Drawing.Point(200, 23);
            this.select_VDSNumber.Name = "select_VDSNumber";
            this.select_VDSNumber.Size = new System.Drawing.Size(100, 21);
            this.select_VDSNumber.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(434, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(657, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.Transparent;
            this.lable.Location = new System.Drawing.Point(638, 27);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(17, 12);
            this.lable.TabIndex = 7;
            this.lable.Text = "到";
            // 
            // VehicleShowPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 584);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.select_VDSNumber);
            this.Controls.Add(this.select_CarNumber);
            this.Controls.Add(this.cmb_ability);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.datagrid_Vehicles);
            this.Name = "VehicleShowPage";
            this.Text = "道路试验数字化平台";
            this.Load += new System.EventHandler(this.VehicleShowPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Vehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_Vehicles;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox cmb_ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDSNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverAbilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyreSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MileageToRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.TextBox select_CarNumber;
        private System.Windows.Forms.TextBox select_VDSNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lable;
    }
}