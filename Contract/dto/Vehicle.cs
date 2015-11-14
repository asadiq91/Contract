using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    /// <summary>
    /// Vehicle object 
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Property for vehicle id
        /// </summary>
        /// <value>
        /// Contains vehicle unique id
        /// </value>
        public int VehicleId { get; set; }
        /// <summary>
        /// Property for the vehicle size
        /// </summary>
        /// <value>
        /// Contains size of the vehicle (1 normal cars size i 1)
        /// </value>
        public int VehicleSize { get; set; }
        /// <summary>
        /// Property for vehicle type
        /// </summary>
        /// <value>
        /// Contains the general name of the vehicle type
        /// </value>
        public string VehicleType { get; set; }
        /// <summary>
        /// Property for price
        /// </summary>
        /// <value>
        /// Contains the price it costs to take the vehicle on the trip
        /// </value>
        public double VehiclePrice { get; set; }
    }
}
