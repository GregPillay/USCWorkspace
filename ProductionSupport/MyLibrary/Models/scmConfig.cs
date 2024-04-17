using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSupport.MyLibrary.Models
{
    public class scmConfig
    {
        public string SerialNumber { get; set; }
        public List<scmJobs> Jobs { get; set; }
    }
    public class scmJobs 
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public DateTime CaptureDateTime { get; set; }
    }
}
