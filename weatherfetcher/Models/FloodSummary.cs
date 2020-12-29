using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weatherfetcher.Models
{
    public class FloodSummary
    {
        public string County { get; set; }
        public string Description { get; set; }
        public string AreaName { get; set; }
        public string Message { get; set; }
        public int SeverityLevel { get; set; }
    }
}
