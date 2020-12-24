using Newtonsoft.Json;
using SAICVolkswagenVehicleManagement_Model;
using SAICVolkswagenVehicleManagementUI.Common;
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
        /// <summary>
        /// 首页加载事件
        /// </summary>
        public InsertVehiclePage()
        {
            InitializeComponent();
        }
        //实例化HttpClient
        HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
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

        private void InsertVehiclePage_Load(object sender, EventArgs e)
        {
            //首页加载下拉框
            GetAbility();
        }
    }
}