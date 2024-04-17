using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigFoxManagement
{
    public class ReportModel
    {
      
        public string SerialNumber { get; set; }
        public int AreaCodeID { get; set; }
        public string RemainingCredit { get; set; }
        public string TotalToDate { get; set; }
        public string LeakDetected { get; set; }
        public string MagneticTamperDetected { get; set; }
        public string BatteryDetected { get; set; }
        public string TamperDetected { get; set; }
        public string OpticalTamperDetected { get; set; }
        public string ValveFaultDetected { get; set; }
        public string ValveClosed { get; set; }
        public string TimeStamp { get; set; }
    }
}
