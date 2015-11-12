using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public int TripId { get; set; }
        public int? VehicleId { get; set; }
        public double TotalPrice { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
