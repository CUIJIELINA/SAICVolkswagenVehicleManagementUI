using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SAICVolkswagenVehicleManagementUI.Common;
using SAICVolkswagenVehicleManagement_Model;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace SAICVolkswagenVehicleManagementUI.Page
{
    public partial class LoginPage : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        #region 页面构造函数
        /// <summary>
        /// 页面构造函数
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            this.BackgroundImage = System.Drawing.Image.FromFile(@"\\192.168.1.9\CuiJ\SAICVolkswagenVehicleManagement\SAICVolkswagenVehicleManagementUI\SAICVolkswagenVehicleManagementUI\Images\微信图片2.jpg");
            //this.BackColor = Color.DeepSkyBlue;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            this.DateTimeNow.BackColor = Color.Transparent;
            this.txt_PassWord.PasswordChar = '*';
        }
        #endregion

        HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
        AutoSizeFormClass asc = new AutoSizeFormClass();
        #region 首页加载窗体
        /// <summary>
        /// 首页加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string weekStr = string.Empty;
        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.NowDateTimer.Start();
            //把得到的星期转换成中文
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
            asc.controllInitializeSize(this);
        }

        #endregion

        #region 定时器timer
        /// <summary>
        /// 定时器timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NowDateTimer_Tick(object sender, EventArgs e)
        {
            this.DateTimeNow.Text = "您好，欢迎登录系统，当前时间：" + DateTime.Now.ToString() + "  " + weekStr;
        }
        #endregion

        //#region 编辑验证码图片
        ///// <summary>
        ///// 编辑验证码图片
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //string str = string.Empty;
        //private void link_ReLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Random random = new Random();
        //    //随机产生5个字符串
        //    str = string.Empty;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        int j = random.Next(64, 90);
        //        str = str + (char)j;
        //    }
        //    //创建图片
        //    Bitmap bmp = new Bitmap(120, 30);
        //    //创建GDI对象
        //    Graphics g = Graphics.FromImage(bmp);
        //    //循环画字符串
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        Point p = new Point(i * 20, 0);
        //        //随机字体
        //        string[] fonts = { "宋体", "黑体", "微软雅黑", "隶属", "仿宋" };
        //        //随机颜色
        //        Color[] colors = { Color.Red, Color.Aquamarine, Color.Blue, Color.Yellow, Color.Black, Color.Pink };
        //        //画字符串
        //        g.DrawString(str[i].ToString(), new Font(fonts[random.Next(0, fonts.Length)], 20, FontStyle.Bold), new SolidBrush(colors[random.Next(0, colors.Length)]), p);
        //    }
        //    //画线
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Point p1 = new Point(random.Next(0, bmp.Width), random.Next(0, bmp.Height));
        //        Point p2 = new Point(random.Next(0, bmp.Width), random.Next(0, bmp.Height));
        //        g.DrawLine(new Pen(Color.Green), p1, p2);
        //    }
        //    //画像素点
        //    for (int i = 0; i < 200; i++)
        //    {
        //        Point p = new Point(random.Next(0, bmp.Width), random.Next(0, bmp.Height));
        //        bmp.SetPixel(p.X, p.Y, Color.Black);
        //    }
        //    //将图片镶嵌到picturebox
        //    this.Pic.Image = bmp;
        //}
        //#endregion

        #region 点击登录事件
        /// <summary>
        /// 点击登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //获取到所有员工信息
            string strUserInfo = httpClient.Get("/UserInfo/GetUserInfo");
            Data data = JsonConvert.DeserializeObject<Data>(strUserInfo);
            List<R_UserInfo> userList = JsonConvert.DeserializeObject<List<R_UserInfo>>(data.Result.ToString());
            R_UserInfo model = userList.Where(s => s.UserName == txt_User.Text && s.UserPassWord == txt_PassWord.Text).FirstOrDefault();
            if (model == null)
            {
                MessageBox.Show("没有当前用户，请重新注册!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HomePage homePage = new HomePage();
                homePage.ShowDialog();
            }
            if (!string.IsNullOrEmpty(txt_User.Text))
            {
                if (txt_User.Text == model.UserName)
                {
                    if (string.IsNullOrEmpty(txt_PassWord.Text))
                    {
                        MessageBox.Show("登录密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                    }
                    else
                    {
                        #region 登录成功
                        if (txt_PassWord.Text == model.UserPassWord)
                        {




                            //记住账号密码 自动登录
                            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                            cfa.AppSettings.Settings["userName"].Value = this.txt_User.Text; // 账号（默认记住）
                            if (this.loginCheckBoxIs.Checked)
                            {
                                cfa.AppSettings.Settings["autoLogin"].Value = "true";
                                cfa.AppSettings.Settings["rememberMe"].Value = "true";
                                cfa.AppSettings.Settings["passWord"].Value = this.txt_PassWord.Text;
                            }
                            else
                            {
                                if (this.loginCheckBoxUne.Checked)
                                {
                                    cfa.AppSettings.Settings["autoLogin"].Value = "false"; // 自动登录
                                    cfa.AppSettings.Settings["rememberMe"].Value = "true"; // 自动赋值
                                    cfa.AppSettings.Settings["passWord"].Value = this.txt_PassWord.Text; // 密码
                                }
                                else
                                {
                                    cfa.AppSettings.Settings["autoLogin"].Value = "false"; // 自动登录
                                    cfa.AppSettings.Settings["rememberMe"].Value = "false"; // 自动赋值
                                    cfa.AppSettings.Settings["passWord"].Value = this.txt_PassWord.Text; // 密码
                                }
                            }
                            cfa.Save();//保存数据
                            MessageBox.Show("登录成功", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            //登录成功进去首页
                            FirstPage firstPage = new FirstPage(model);
                            firstPage.Show();

                        }
 
                        else
                        {
                            MessageBox.Show("密码错误，请重新输入!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                        }
                        #endregion
                    }
                }
                else
                {
                    MessageBox.Show("没有当前用户，请重新注册!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            else
            {
                MessageBox.Show("登录用户不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
        }

        #endregion

        #region 点击注册
        /// <summary>
        /// 点击注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Register_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }
        #endregion

        #region 窗体第一个显示时发生
        /// <summary>
        /// 窗体第一个显示时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPage_Shown(object sender, EventArgs e)
        {
            this.txt_User.Text = ConfigurationManager.AppSettings["userName"];
            if (ConfigurationManager.AppSettings["rememberMe"].Equals("true"))
            {
                this.txt_PassWord.Text = ConfigurationManager.AppSettings["passWord"];
                loginCheckBoxUne.Checked = true;
                loginCheckBoxIs.Checked = false;
            }
            if (ConfigurationManager.AppSettings["autoLogin"].Equals("true"))
            {
                loginCheckBoxUne.Checked = true;
                loginCheckBoxIs.Checked = true;
                btn_Login_Click(sender, e);
            }

            if (txt_User.Text.Equals(""))
            {
                txt_User.Focus(); // 获取输入账号焦点
            }
            else if (txt_PassWord.Equals(""))
            {
                txt_PassWord.Focus(); // 获取输入密码焦点
            }
            else
                btn_Login.Focus();
        }
        #endregion

        #region 跳转到修改密码页面
        /// <summary>
        /// 跳转到修改密码页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_UpdatePassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //获取所有的用户信息
            string strUserInfo = httpClient.Get("/UserInfo/GetUserInfo");
            Data data = JsonConvert.DeserializeObject<Data>(strUserInfo);
            List<R_UserInfo> listUserInfo = JsonConvert.DeserializeObject<List<R_UserInfo>>(data.Result.ToString());
            //根据用户名和密码找到这一条数据
            R_UserInfo model = listUserInfo.Where(s => s.UserName == txt_User.Text && s.UserPassWord == txt_PassWord.Text).FirstOrDefault();
            UpdatePassWordPage updatePassWordPage = new UpdatePassWordPage(model);
            updatePassWordPage.ShowDialog();
        }
        #endregion

        /// <summary>
        /// 窗体最大化，自适应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPage_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
    }
}