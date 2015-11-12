using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    public class Ferry
    {
        public int FerryId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int PassengerCapacity { get; set; }
        public string Municipality { get; set; }
        public int? DockId { get; set; }
    }
}
