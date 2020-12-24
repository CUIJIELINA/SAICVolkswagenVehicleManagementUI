using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAICVolkswagenVehicleManagement_Model
{
    public class AbilityInfo
    {
        [Key]
        public int DriverAbilityID { get; set; }
        public string DriverAbilityName { get; set; }
    }
}
