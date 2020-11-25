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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private R_UserInfo userInfo;
        public FirstPage(R_UserInfo _userInfo)
        {
            this.userInfo = _userInfo;
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"\\192.168.1.9\CuiJ\SAICVolkswagenVehicleManagement\SAICVolkswagenVehicleManagementUI\SAICVolkswagenVehicleManagementUI\Images\图片1.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.datagrid_UserInfo.DataSource = GetUserInfo();
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

        /// <summary>
        /// 首页加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string weekStr = string.Empty;
        private void FirstPage_Load(object sender, EventArgs e)
        {
            //开启定时器
            this.NowDateTimer.Start();
            //把得到的星期换成中文
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": weekStr = "星期一"; break;
                case "Tuesday": weekStr = "星期二"; break;
                case "Wednesday": weekStr = "星期三"; break;
                case "Thursday": weekStr = "星期四"; break;
                case "Friday": weekStr = "星期五"; break;
                case "Saturday": weekStr = "星期六"; break;
                case "Sunday": weekStr = "星期日"; break;
                default: break;
            }
            var topNode = new TreeNode();
            topNode.Name = "0";
            topNode.Text = "道路试验数字化";
            this.Menu_treeView.Nodes.Add(topNode);
            Bind(topNode,GetPermissions(),0);
        }

        /// <summary>
        /// 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NowDateTimer_Tick(object sender, EventArgs e)
        {
            this.lab_NowDateTimer.Text = $"欢迎{userInfo.UserName}登录，今天是：{DateTime.Now.ToString("yyyy年MM月dd日")}  {weekStr}";
        }

        #region 点击退出系统
        /// <summary>
        /// 点击退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_TuiChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否确认退出系统","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
            }
        }
        #endregion

        /// <summary>
        /// 获取菜单信息
        /// </summary>
        /// <returns></returns>
        public List<Permission> GetPermissions()
        {
            HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
            string PermissionInfo = httpClient.Get("/Menu/GetPermission");
            Data data = JsonConvert.DeserializeObject<Data>(PermissionInfo);
            List<Permission> permissions = JsonConvert.DeserializeObject<List<Permission>>(data.Result.ToString());
            return permissions;
        }

        /// <summary>
        /// 绑定TreeView数据信息
        /// </summary>
        /// <param name="parNode"></param>
        /// <param name="permissions"></param>
        /// <param name="nodeId"></param>
        public void Bind(TreeNode parNode,List<Permission> permissions,int nodeId)
        {
            var childList = permissions.FindAll(t => t.UpID == nodeId).OrderBy(t => t.PermissionID);
            foreach (var item in childList)
            {
                TreeNode node = new TreeNode();
                node.Name = item.PermissionID.ToString();
                node.Text = item.PermissionName;
                parNode.Nodes.Add(node);
                Bind(node,permissions,item.PermissionID);
            }
        }
    }
}
