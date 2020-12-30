using Newtonsoft.Json;
using SAICVolkswagenVehicleManagement_Common;
using SAICVolkswagenVehicleManagement_Model;
using SAICVolkswagenVehicleManagementUI.Common;
using SAICVolkswagenVehicleManagementUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAICVolkswagenVehicleManagementUI.Page
{
    public partial class VehicleShowPage : Form
    {
        //实例化HttpClient
        HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
        AutoSizeFormClass asc = new AutoSizeFormClass();
        int width = 0;
        public VehicleShowPage()
        {
            InitializeComponent();
        }

        #region 首页加载事件
        private void VehicleShowPage_Load(object sender, EventArgs e)
        {
            this.datagrid_Vehicles.AutoGenerateColumns = false;
            //绑定GridView数据
            this.datagrid_Vehicles.DataSource = GetVehicle();
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < this.datagrid_Vehicles.Columns.Count; i++)
            {
                //将每一列都调整为自动 适应模式
                this.datagrid_Vehicles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += this.datagrid_Vehicles.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度
            //则将DataGridView的列自动调整模式设置为显示的列即可
            //如果是小于原来设定的宽度，将模式改为填充
            if (width > this.datagrid_Vehicles.Size.Width)
                this.datagrid_Vehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            else
                this.datagrid_Vehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //冻结某列从左0,1,2
            this.datagrid_Vehicles.Columns[1].Frozen = true;
            //DataGridView无边框
            this.datagrid_Vehicles.BorderStyle = BorderStyle.None;
            DataGridViewStyle.DgvStyle3(this.datagrid_Vehicles);
            //绑定下拉框
            GetAbility();
            asc.controllInitializeSize(this);
        }
        #endregion

        #region 获取车辆参数信息
        /// <summary>
        /// 获取车辆参数信息
        /// </summary>
        public List<VehicleAndAbilityDto> GetVehicle()
        {
            HttpClientHelper helper = new HttpClientHelper("http://localhost:50386");
            //通过HttpClient获取数据
            string strVehicleShow = helper.Get("/VehicleParameters/GetVehicleParameters");
            //转换为对象
            Data data = JsonConvert.DeserializeObject<Data>(strVehicleShow);
            List<VehicleAndAbilityDto> vehicles = JsonConvert.DeserializeObject<List<VehicleAndAbilityDto>>(data.Result.ToString());
            foreach (VehicleAndAbilityDto item in vehicles)
            {
                item.strOdometer = item.Odometer + "km";
                item.strCurrentMileage = item.CurrentMileage + "km";
                item.strRemainingMileage = item.RemainingMileage + "km";
                item.strMileageToRun = item.MileageToRun + "km";
                item.strRemainingFrequency = item.RemainingFrequency + "次";
            }
            return vehicles;
        }
        #endregion

        #region 点击查询事件
        /// <summary>
        /// 点击查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_select_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmb_ability.Text.Trim()) && string.IsNullOrEmpty(select_CarNumber.Text.Trim()) && string.IsNullOrEmpty(select_VDSNumber.Text.Trim()))
            {
                GetVehicle();
                return;
            }
            else
            {
                //先找到所有的车辆参数信息
                List<VehicleAndAbilityDto> vehicles = GetVehicle();
                //给一个空的list
                List<VehicleAndAbilityDto> list = null;
                //判断需要查询的数据是否为空
                if (!string.IsNullOrEmpty(cmb_ability.Text.Trim()))
                    list = vehicles.Where(s => s.DriverAbilityName.Equals(cmb_ability.Text.Trim())).ToList();
                //根据车号进行查询
                if (!string.IsNullOrEmpty(select_CarNumber.Text.Trim()))
                    list = vehicles.Where(s => s.CarNumber.Equals(select_CarNumber.Text.Trim())).ToList();
                //根据VDS号进行查询
                if (!string.IsNullOrEmpty(select_VDSNumber.Text.Trim()))
                    list = vehicles.Where(s => s.VDSNumber.Equals(select_VDSNumber.Text.Trim())).ToList();
                //按开始时间和结束时间进行查询

                //重新绑定数据
                datagrid_Vehicles.DataSource = list;
            }
        }
        #endregion

        #region 绑定下拉框
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        public void GetAbility()
        {
            //通过HttpClinet获取能力数据
            string strAbility = httpClient.Get("/Ability/GetAbility");
            //转换成对象
            Data data = JsonConvert.DeserializeObject<Data>(strAbility);
            //list接收
            List<AbilityInfo> abilities = JsonConvert.DeserializeObject<List<AbilityInfo>>(data.Result.ToString());
            cmb_ability.ValueMember = "DriverAbilityID";
            cmb_ability.DisplayMember = "DriverAbilityName";
            cmb_ability.DataSource = abilities;
        }
        #endregion

        #region DataGridView自带行号
        /// <summary>
        /// DataGridView自带行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagrid_Vehicles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
                this.datagrid_Vehicles.Rows[e.RowIndex + i].HeaderCell.Value = (e.RowIndex + i + 1).ToString();
        }
        #endregion

    }
}
