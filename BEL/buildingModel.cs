using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class buildingModel
    {
        public int id { get; set; }
        public int buildingCode { get; set; }
        public string buildingName { get; set; }
        public int totalFloors { get; set; }
        public int totalFlats { get; set; }
        public string ownerName { get; set; }
        public Nullable<int> colonyCode { get; set; }
        public string username { get; set; }
    }
}
