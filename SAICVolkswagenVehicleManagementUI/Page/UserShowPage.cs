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
    public partial class UserShowPage : Form
    {
        HttpClientHelper httpClient = new HttpClientHelper("http://localhost:50386");
        int width = 0;
        public UserShowPage()
        {
            InitializeComponent();
            this.datagrid_UserInfo.AutoGenerateColumns = false;
            this.datagrid_UserInfo.DataSource = GetUserInfo();
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < this.datagrid_UserInfo.Columns.Count; i++)
            {
                //将每一列都调整为自动 适应模式
                this.datagrid_UserInfo.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += this.datagrid_UserInfo.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度
            //则将DataGridView的列自动调整模式设置为显示的列即可
            //如果是小于原来设定的宽度，将模式改为填充
            if (width > this.datagrid_UserInfo.Size.Width)
                this.datagrid_UserInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            else
                this.datagrid_UserInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //冻结某列从左0,1,2
            this.datagrid_UserInfo.Columns[1].Frozen = true;
            //DataGridView无边框
            this.datagrid_UserInfo.BorderStyle = BorderStyle.None;
            DataGridViewStyle.DgvStyle3(this.datagrid_UserInfo);
            //绑定下拉框
            GetDeptmentInfo();
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
        /// DataGridView自带行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagrid_UserInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
                this.datagrid_UserInfo.Rows[e.RowIndex + i].HeaderCell.Value = (e.RowIndex + i + 1).ToString();
        }

        /// <summary>
        /// 点击查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_select_Click(object sender, EventArgs e)
        {
            //先找到所有的数据
            List<UserAndDepartmentDto> users = GetUserInfo();
            List<UserAndDepartmentDto> list = null;
            //按条件查询
            if(!string.IsNullOrEmpty(this.select_name.Text.Trim()))
                list = users.Where(s => s.UserName.Contains(this.select_name.Text.Trim())).ToList();
            if(!string.IsNullOrEmpty(this.cmb_Department.Text.Trim()))
                list = users.Where(s => s.DepartmentName.Equals(this.cmb_Department.Text.Trim())).ToList();
            if(!string.IsNullOrEmpty(this.cmb_depart.Text.Trim()))
                list = users.Where(s => s.DepartmentName.Equals(this.cmb_depart.Text.Trim())).ToList();
            //重新绑定数据
            this.datagrid_UserInfo.DataSource = list;
        }
        string department = string.Empty;
        /// <summary>
        /// 绑定部门下拉框
        /// </summary>
        public void GetDeptmentInfo()
        {
            //获取部门信息
            department = httpClient.Get("/Department/GetDepartment");
            //转换成对象
            Data data = JsonConvert.DeserializeObject<Data>(department);
            List<DepartmentInfo> departmentInfoList = JsonConvert.DeserializeObject<List<DepartmentInfo>>(data.Result.ToString()).Where(m => m.UpID == 0).ToList();
            this.cmb_Department.ValueMember = "DepartmentID";
            this.cmb_Department.DisplayMember = "DepartmentName";
            this.cmb_Department.Tag = "UpID";
            this.cmb_Department.DataSource = departmentInfoList;
        }

        /// <summary>
        /// 输入改变事件
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
    }
}
