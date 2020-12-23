using Newtonsoft.Json;
using SAICVolkswagenVehicleManagement_Common;
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
    public partial class UserShowPage : Form
    {
        public UserShowPage()
        {
            InitializeComponent();
            this.datagrid_UserInfo.AutoGenerateColumns = false;
            this.datagrid_UserInfo.DataSource = GetUserInfo();
            DataGridViewStyle.DgvStyle3(this.datagrid_UserInfo);
        }

        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <returns></returns>
        public List<UserAndDepartmentDto> GetUserInfo()
        {
            HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
            string UserInfo = httpClient.Get("/UserInfo/GetUserInfo");
            Data data = JsonConvert.DeserializeObject<Data>(UserInfo);
            List<UserAndDepartmentDto> userInfos = JsonConvert.DeserializeObject<List<UserAndDepartmentDto>>(data.Result.ToString());
            return userInfos;
        }
    }
}
