using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAICVolkswagenVehicleManagementUI.Models
{
    public class VehicleAndAbilityDto
    {
        public int VPId { get; set; }
        public string CarNumber { get; set; }
        public string VDSNumber { get; set; }
        public string ProjectNumber { get; set; }
        public string CarModel { get; set; }
        public int AbilityId { get; set; }
        public DateTime StateDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EngineStructure { get; set; }
        public string EngineNumber { get; set; }
        public string Transmission { get; set; }
        public string TyreSize { get; set; }
        public string Remark { get; set; }
        public double CurrentMileage { get; set; }
        public double RemainingMileage { get; set; }
        public double Odometer { get; set; }
        public double MileageToRun { get; set; }
        public string RemainingFrequency { get; set; }
        public string DriverAbilityName { get; set; }
        public string strOdometer { get; set; }
        public string strCurrentMileage { get; set; }
        public string strRemainingMileage { get; set; }
        public string strMileageToRun { get; set; }
        public string strRemainingFrequency { get; set; }
    }
}
