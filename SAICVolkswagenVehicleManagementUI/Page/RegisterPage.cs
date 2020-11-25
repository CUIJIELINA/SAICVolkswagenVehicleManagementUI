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
using SAICVolkswagenVehicleManagement_Model;
using Newtonsoft.Json;
using SAICVolkswagenVehicleManagementUI.Models;
using SAICVolkswagenVehicleManagementUI.Page;
using System.Text.RegularExpressions;

namespace SAICVolkswagenVehicleManagementUI
{
    public partial class HomePage : Form
    {
        HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
        public HomePage()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"\\192.168.1.10\CuiJ\SAICVolkswagenVehicleManagement\SAICVolkswagenVehicleManagementUI\SAICVolkswagenVehicleManagementUI\Images\图片1.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;

        }

        #region 获取验证码
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int seconds1 = 60;
        private int seconds2 = 60 * 5;
        private string strMailVeriCode;
        private void link_VerificationCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string recEMailAddress = txt_QQMail.Text.Trim();
            strMailVeriCode = MailVeriCodeClass.CreateRandomMailCode(6);
            string strBody = $"验证码：{strMailVeriCode},5分钟内有效,请勿泄漏于他人。如非本人操作,请忽略。系统邮件请勿回复!";
            string strSubject = "崔杰【科技】";//邮件标题
            string strMyEmailAddress = "2501023011@qq.com";//发件人邮箱
            string strAuthorizationCode = "lssukrgcortkdijj";//邮箱授权码
            //判断是否输入了邮箱
            if (string.IsNullOrEmpty(recEMailAddress))
            {
                MessageBox.Show("请输入邮箱！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_QQMail.Focus();
            }
            else if (MailVeriCodeClass.CheckMail(recEMailAddress) == false)
            {
                MessageBox.Show("您输入的QQ邮箱有误,请重新输入!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_QQMail.Focus();
                return;
            }
            else
            {
                if (MailVeriCodeClass.SendMailMessage(strMyEmailAddress, recEMailAddress, strSubject, strBody, strAuthorizationCode) == true)
                {
                    link_VerificationCode.Enabled = false;
                    timer1.Interval = 1000;
                    timer1.Start();
                    timer2.Interval = 1000;
                    timer2.Start();
                }
                else
                    txt_QQMail.Focus();
            }
        }
        #endregion

        #region 验证码定时器设置
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds1 > 0)
            {
                seconds1--;
                link_VerificationCode.Text = $"剩余{seconds1.ToString()}秒";
            }
            else
            {
                timer1.Stop();
                link_VerificationCode.Text = "获取邮箱验证码";
                link_VerificationCode.Enabled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds2 == 0)
            {
                timer2.Stop();
                //旧的验证码过期，生成一个新的验证码
                strMailVeriCode = MailVeriCodeClass.CreateRandomMailCode(6);
            }
        }
        #endregion

        #region 点击取消退出注册页面
        /// <summary>
        /// 点击取消退出注册页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }
        #endregion

        #region 首页加载窗体
        //星期几
        string weekStr = string.Empty;
        //获取的部门的字符串信息
        string department = string.Empty;
        //部门集合
        List<DepartmentInfo> departmentInfoList = null;
        private void HomePage_Load(object sender, EventArgs e)
        {
            this.DateTimerNow.Start();
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
            //绑定部门下拉框
            department = httpClient.Get("/Department/GetDepartment");
            Data data = JsonConvert.DeserializeObject<Data>(department);
            departmentInfoList = (JsonConvert.DeserializeObject<List<DepartmentInfo>>(data.Result.ToString())).Where(m => m.UpID == 0).ToList();
            this.cmb_Department.ValueMember = "DepartmentID";
            this.cmb_Department.DisplayMember = "DepartmentName";
            this.cmb_Department.Tag = "UpID";
            this.cmb_Department.DataSource = departmentInfoList;
        }
        #endregion

        #region 显示当前时间定时器
        /// <summary>
        /// 显示当前时间定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimerNow_Tick(object sender, EventArgs e)
        {
            this.DateTimeNow.Text = "您好，欢迎登录系统，当前时间：" + DateTime.Now.ToString() + "  " + weekStr;
        }
        #endregion

        #region 点击注册事件
        /// <summary>
        /// 点击注册事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Register_Click(object sender, EventArgs e)
        {
            #region 非空判断
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                lab_Name.Text = "必填项不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_PassWord.Text))
            {
                lab_PassWord.Text = "必填项不能为空"; return;
            }
            if (string.IsNullOrEmpty(txt_BeginPassWord.Text))
            {
                lab_BeignPassWord.Text = "必填项不能为空"; return;
            }
            if(string.IsNullOrEmpty(txt_QQMail.Text))
            {
                QQEMail.Text = "必填项不能为空"; return;
            }
            if(string.IsNullOrEmpty(txt_VerificationCode.Text))
            {
                throw new Exception("验证码不能为空");
            }
            Regex regex = new Regex(@"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?");
            if(regex.IsMatch(txt_QQMail.Text) == false)
            {
                QQEMail.Text = "请输入正确的邮箱格式";return;
            }
            #endregion

            string password = this.txt_PassWord.Text;
            string sex = this.rab_nan.Checked ? "男" : "女";
            UserAndDepartmentDto infos = new UserAndDepartmentDto()
            {
                UserCode = this.txt_Code.Text,
                UserName = this.txt_Name.Text,
                DepartmentName = this.cmb_Department.Text + this.cmb_depart.Text,
                UserPassWord = password,
                UserSex = sex,
                UserRemark = this.txt_UserRemark.Text,
                E_Mail = this.txt_QQMail.Text,
                Birthday = this.date_birthday.Value,
                CreateDate = DateTime.Now,
                Department_ID = (int)this.cmb_depart.SelectedValue
            };
            string httpstr = httpClient.Post("/UserInfo/InsertUserInfo", infos);
            Data data = JsonConvert.DeserializeObject<Data>(httpstr);
            if (data.Result.ToString() == "1")
            {
                MessageBox.Show("注册成功", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
            }
            else
            {
                MessageBox.Show("注册失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region 验证密码失去焦点事件
        /// <summary>
        /// 验证密码失去焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_BeginPassWord_MouseLeave(object sender, EventArgs e)
        {
            string beginPassWord = this.txt_BeginPassWord.Text;
            string password = this.txt_PassWord.Text;
            if (beginPassWord != password)
            {
                MessageBox.Show("两次输入密码不一致", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #region 验证邮箱验证码是否输入正确
        /// <summary>
        /// 验证邮箱验证码是否输入正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_VerificationCode_MouseLeave(object sender, EventArgs e)
        {
            //邮箱验证码
            string mailVeriCode = this.txt_VerificationCode.Text;
            if (string.IsNullOrEmpty(mailVeriCode) == true)
            {
                MessageBox.Show("请输入验证码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_VerificationCode.Focus();
            }
            else if (mailVeriCode.ToLower() != strMailVeriCode.ToLower())//判断邮箱验证码是否输入正确；不区分字母大小写
            {
                MessageBox.Show("您输入的验证码有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_VerificationCode.Focus();
                return;
            }
            else
            {
                MessageBox.Show("验证成功!", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 总公司改变事件
        /// <summary>
        /// 总公司改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_depart.DataSource = null;
            //获取上级ID
            int Id = (int)this.cmb_Department.SelectedValue;
            //先获取到所有的部门信息
            Data data = JsonConvert.DeserializeObject<Data>(department);
            //所有部门信息
            List<DepartmentInfo> departments = JsonConvert.DeserializeObject<List<DepartmentInfo>>(data.Result.ToString());
            //子部门信息
            List<DepartmentInfo> child = departments.Where(m => m.UpID == Id).ToList();
            cmb_depart.DisplayMember = "DepartmentName";
            cmb_depart.ValueMember = "DepartmentID";
            cmb_depart.Tag = "UpID";
            cmb_depart.DataSource = child;
        }
        #endregion

        #region 输入数据是文本框改变事件
        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Name.Text))
            {
                lab_Name.Text = "*"; return;
            }
        }
        private void txt_PassWord_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PassWord.Text))
            {
                lab_PassWord.Text = "*"; return;
            }
        }
        private void txt_BeginPassWord_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BeginPassWord.Text))
            {
                lab_BeignPassWord.Text = "*"; return;
            }
        }
        private void txt_QQMail_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?");
            if (regex.IsMatch(txt_QQMail.Text) == true)
            {
                QQEMail.Text = "邮箱格式正确"; return;
            }
        }
        #endregion
    }
}
