using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class report
    {
        public string idOfReport { get; set; }
        public List<DetalsOfReport> Reports { get; set; }
    }
    public class DetalsOfReport
    {
        public string Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Staff { get; set; }
        public string status { get; set; }
    }
}
