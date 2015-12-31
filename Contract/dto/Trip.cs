using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    /// <summary>
    /// Trip object
    /// </summary>
    public class Trip
    {
        /// <summary>
        /// Property for trip id
        /// </summary>
        /// <value>
        /// Contains the trips unique id
        /// </value>
        public int TripId { get; set; }
        /// <summary>
        /// Property for depature time
        /// </summary>
        /// <value>
        /// Contains time of depature for the trip
        /// </value>
        public DateTime DepatureTime { get; set; }
        /// <summary>
        /// Property for route 
        /// </summary>
        /// <value>
        /// Contains id of the route of the trip
        /// </value>
        public Route Route { get; set; }
        /// <summary>
        /// Property for ferry 
        /// </summary>
        /// <value>
        /// Contains the id of the ferry, sailing the route for the trip
        /// </value>
        public Ferry Ferry { get; set; }
        /// <summary>
        /// Property for the trip price
        /// </summary>
        /// <value>
        /// Contains price for the trip
        /// </value>
        public double TripPrice { get; set; }
    }
}
