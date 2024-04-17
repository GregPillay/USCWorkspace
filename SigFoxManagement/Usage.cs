using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigFoxManagement
{
   

    public class UsageTypeIds
    {
        public int UsageTypeId { get; set; }
        public string SettingType { get; set; }
        public int DateCaptured { get; set; }
        public int TimeCaptured { get; set; }
        public string StringValue { get; set; }
        public double NumericValue { get; set; }
    }
}
