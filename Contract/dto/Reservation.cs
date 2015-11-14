using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    /// <summary>
    /// Reservation object
    /// </summary>
    public class Reservation
    {
        /// <summary>
        /// Property for reservation id
        /// </summary>
        /// <value>
        /// Contains the reservations unique id
        /// </value>
        public int ReservationId { get; set; }
        /// <summary>
        /// Property for customer id
        /// </summary>
        /// <value>
        /// Contains customers unique id, who made the reservation
        /// </value>
        public int CustomerId { get; set; }
        /// <summary>
        /// Property for trip id
        /// </summary>
        /// <value>
        /// Contains trips unique id, which the reservation is made for
        /// </value>
        public int TripId { get; set; }
        /// <summary>
        /// Property for vehicle id
        /// </summary>
        /// <value>
        /// Contains the vehicle type id, of the customers vehicle, if customer has any
        /// </value>
        public int? VehicleId { get; set; }
        /// <summary>
        /// Property for total price
        /// </summary>
        /// <value>
        /// Contains total price of the reservation
        /// </value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Property for number of people
        /// </summary>
        /// <value>
        /// Contains number of passengers the reservation i booked for
        /// </value>
        public int NumberOfPeople { get; set; }
    }
}
