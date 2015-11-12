using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    public class Trip
    {
        public int TripId { get; set; }
        public int RouteId { get; set; }
        public int FerryId { get; set; }
        public double Price { get; set; }
    }
}
