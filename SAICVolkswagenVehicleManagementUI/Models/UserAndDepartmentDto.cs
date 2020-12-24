using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAICVolkswagenVehicleManagementUI.Models
{
    public class UserAndDepartmentDto
    {
        public int UserID { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPassWord { get; set; }
        public int Department_ID { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string UserSex { get; set; }
        public string UserRemark { get; set; }
        public string E_Mail { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateDate { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
