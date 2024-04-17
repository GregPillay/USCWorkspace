using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigFoxManagement
{
    internal class SigFoxSkeleton
    {
        public string SerialNumber { get; set; }
        public int AreaCodeId { get; set; }
        public SigFoxDevice sigFoxDevice { get; set; }
        public List< UsageTypeIds> Usage { get; set; }
    }
}
