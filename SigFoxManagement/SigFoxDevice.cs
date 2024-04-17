using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigFoxManagement
{
    public class SigFoxDevice
    {
        public string DeviceId { get; set; }
        public string SerialNumber { get; set; }
        public int AreaCodeId { get; set; }
        public int ProductTypeId { get; set; }
        public int DeviceStatusId { get; set; }
        public int ConfigJobId { get; set; }
        public string ProductionSerialNumber { get; set; }
        public string Description { get; set; }
        public string EndUserId { get; set; }
        public string LpWanId { get; set; }
    }
}
