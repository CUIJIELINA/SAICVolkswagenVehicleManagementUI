using Newtonsoft.Json;
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
    public partial class InsertVehiclePage : Form
    {
        //实例化HttpClient
        HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");

        #region 双缓存技术
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        #endregion

        #region 构造函数
        /// <summary>
        /// 首页加载事件
        /// </summary>
        public InsertVehiclePage()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"\\192.168.1.9\CuiJ\SAICVolkswagenVehicleManagement\SAICVolkswagenVehicleManagementUI\SAICVolkswagenVehicleManagementUI\Images\微信图片2.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
        #endregion

        #region 获取能力信息
        /// <summary>
        /// 获取能力信息
        /// </summary>
        public void GetAbility()
        {
            //获取字符串的值
            string strAbility = httpClient.Get("/Ability/GetAbility");
            //转换成对象
            Data data = JsonConvert.DeserializeObject<Data>(strAbility);
            List<AbilityInfo> abilityInfos = JsonConvert.DeserializeObject<List<AbilityInfo>>(data.Result.ToString());
            this.cmb_Ability.DisplayMember = "DriverAbilityName";
            this.cmb_Ability.ValueMember = "DriverAbilityID";
            this.cmb_Ability.DataSource = abilityInfos;
        }
        #endregion

        #region 首页加载事件
        /// <summary>
        /// 首页加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertVehiclePage_Load(object sender, EventArgs e)
        {
            //首页加载下拉框
            GetAbility();
        }
        #endregion

        #region 点击添加事件
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            #region 非空判断
            if (string.IsNullOrEmpty(txt_VehicleNumber.Text.Trim()))
            {
                lab_VehicleNumber.Text = "车号不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_VDSNumber.Text.Trim()))
            {
                lab_VDSNumber.Text = "VDS编号不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_ProjectNumber.Text.Trim()))
            {
                lab_ProjectNumber.Text = "项目编号不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_CarModel.Text.Trim()))
            {
                lab_CarModel.Text = "车型不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_EngineStructure.Text.Trim()))
            {
                lab_EngineStructure.Text = "发动机结构不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_EngineNumber.Text.Trim()))
            {
                lab_EngineNumber.Text = "发动机号不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_Transmission.Text.Trim()))
            {
                lab_Transmission.Text = "变速箱样式不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_TyreSize.Text.Trim()))
            {
                lab_TyreSize.Text = "轮胎尺寸不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_Odometer.Text.Trim()))
            {
                lab_Odometer.Text = "里程表里程不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_MileageToRun.Text.Trim()))
            {
                lab_MileageToRun.Text = "应跑里程不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_CurrentMileage.Text.Trim()))
            {
                lab_CurrentMileage.Text = "当前里程不能为空"; return;
            }
            #endregion

            //使用初始化器获取文本框中的数据
            VehicleAndAbilityDto vehicles = new VehicleAndAbilityDto()
            {
                CarNumber = txt_VehicleNumber.Text.Trim(),
                VDSNumber = txt_VDSNumber.Text.Trim(),
                DriverAbilityName = cmb_Ability.Text.Trim(),
                AbilityId = (int)cmb_Ability.SelectedValue,
                ProjectNumber = txt_ProjectNumber.Text.Trim(),
                CarModel = txt_CarModel.Text.Trim(),
                EngineStructure = txt_EngineStructure.Text.Trim(),
                EngineNumber = txt_EngineStructure.Text.Trim(),
                Transmission = txt_Transmission.Text.Trim(),
                TyreSize = txt_TyreSize.Text.Trim(),
                Odometer = double.Parse(txt_Odometer.Text.Trim()),
                MileageToRun = double.Parse(txt_MileageToRun.Text.Trim()),
                CurrentMileage = double.Parse(txt_CurrentMileage.Text.Trim())
            };
        }
        #endregion

        #region 点击文本框修改事件
        private void txt_VehicleNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_VehicleNumber.Text.Trim()))
            {
                lab_VehicleNumber.Text = "*"; return;
            }
        }
        private void txt_VDSNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_VDSNumber.Text.Trim()))
            {
                lab_VDSNumber.Text = "*"; return;
            }
        }
        private void txt_ProjectNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ProjectNumber.Text.Trim()))
            {
                lab_ProjectNumber.Text = "*"; return;
            }
        }

        private void txt_CarModel_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CarModel.Text.Trim()))
            {
                lab_CarModel.Text = "*"; return;
            }
        }

        private void txt_EngineStructure_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_EngineStructure.Text.Trim()))
            {
                lab_EngineStructure.Text = "*"; return;
            }
        }

        private void txt_EngineNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_EngineNumber.Text.Trim()))
            {
                lab_EngineNumber.Text = "*"; return;
            }
        }

        private void txt_Transmission_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Transmission.Text.Trim()))
            {
                lab_Transmission.Text = "*"; return;
            }
        }

        private void txt_TyreSize_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TyreSize.Text.Trim()))
            {
                lab_TyreSize.Text = "*"; return;
            }
        }

        private void txt_Odometer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Odometer.Text.Trim()))
            {
                lab_Odometer.Text = "*"; return;
            }
        }

        private void txt_MileageToRun_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MileageToRun.Text.Trim()))
            {
                lab_MileageToRun.Text = "*"; return;
            }
        }

        private void txt_CurrentMileage_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CurrentMileage.Text.Trim()))
            {
                lab_CurrentMileage.Text = "*"; return;
            }
        }
        #endregion

    }
}