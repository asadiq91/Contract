using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    /// <summary>
    /// Route object
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Property for route id
        /// </summary>
        /// <value>
        /// Contains the route's unique id
        /// </value>
        public int RouteId { get; set; }
        /// <summary>
        /// Property for depature
        /// </summary>
        /// <value>
        /// Contains the name of the depature city of the trip
        /// </value>
        public string Depature { get; set; }
        /// <summary>
        /// Property for destination
        /// </summary>
        /// <value>
        /// Contains the name of the destination name of the trip
        /// </value>
        public string Destination { get; set; }
        /// <summary>
        /// Property for duration
        /// </summary>
        /// <value>
        /// Contains duration of the trip i minutes
        /// </value>
        public int Duration { get; set; }
    }
}
