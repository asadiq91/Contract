using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    public class Route
    {
        public int RouteId { get; set; }
        public string Depature { get; set; }
        public string Destination { get; set; }
        public int Duration { get; set; }
    }
}
