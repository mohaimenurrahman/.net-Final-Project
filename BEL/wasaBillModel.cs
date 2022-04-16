using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class wasaBillModel
    {
        public int id { get; set; }
        public int buildingCode { get; set; }
        public string flatNumber { get; set; }
        public string datestart { get; set; }
        public string dateend { get; set; }
        public string unitAmount { get; set; }
        public string totalAmount { get; set; }
        public string status { get; set; }
    }
}
