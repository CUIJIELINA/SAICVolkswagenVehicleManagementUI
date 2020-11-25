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
    public partial class UpdatePassWordPage : Form
    {
        private R_UserInfo userInfo;
        HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
        public UpdatePassWordPage()
        {
            InitializeComponent();
            
        }
        public UpdatePassWordPage(R_UserInfo _UserInfo)
        {
            this.userInfo = _UserInfo;
            InitializeComponent();
            this.lab_UserID.Hide();
            this.BackgroundImage = Image.FromFile(@"Z:\SAICVolkswagenVehicleManagement\SAICVolkswagenVehicleManagementUI\SAICVolkswagenVehicleManagementUI\Images\图片1.jpg");
            //this.BackColor = Color.DeepSkyBlue;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePassWordPage_Load(object sender, EventArgs e)
        {
            this.lab_UserID.Text = userInfo.UserID.ToString();
        }

        /// <summary>
        /// 点击修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditPassWord_Click(object sender, EventArgs e)
        {
            //获取所有的用户信息
            string strUserInfo = httpClient.Get("/UserInfo/GetUserInfo");
            Data data = JsonConvert.DeserializeObject<Data>(strUserInfo);
            List<R_UserInfo> listUserInfo = JsonConvert.DeserializeObject<List<R_UserInfo>>(data.Result.ToString());
            //根据用户名和密码找到这一条数据
            R_UserInfo model = listUserInfo.Where(s => s.UserName == userInfo.UserName && s.UserPassWord == userInfo.UserPassWord).FirstOrDefault();
            if(txt_oldPassWord.Text == model.UserPassWord)
            {
                if(txt_newPassWord.Text == txt_beginPassWord.Text)
                {
                    model.UserPassWord = this.txt_newPassWord.Text;
                    //执行修改事件
                    string jsonData = httpClient.Put("/UserInfo/UpdateUserInfo", model);
                    Data strData = JsonConvert.DeserializeObject<Data>(jsonData);
                    if(strData.Result.ToString() == "1")
                    {
                        MessageBox.Show("修改成功", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginPage loginPage = new LoginPage();
                        this.Hide();
                        loginPage.Show();
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                }
                else
                {
                    MessageBox.Show("两次输入密码不正确", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
                }
            }
            else
            {
                MessageBox.Show("用户不存在","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);return;
            }
        }
    }
}
