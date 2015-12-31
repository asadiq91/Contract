using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    /// <summary>
    /// Ferry object
    /// </summary>
    public class Ferry
    {
        /// <summary>
        /// Property for FerryId
        /// </summary>
        /// <value>
        /// Contains ferry's unique id
        /// </value>
        public int FerryId { get; set; }
        /// <summary>
        /// Property for ferry name
        /// </summary>
        /// <value>
        /// Contains name of the ferry
        /// </value>
        public string FerryName { get; set; }
        /// <summary>
        /// Property for ferry size 
        /// </summary>
        /// <value>
        /// Contains the size of the ferry
        /// </value>
        public string FerrySize { get; set; }
        /// <summary>
        /// Property for passenger capacity
        /// </summary>
        /// <value>
        /// Contains the number of passengers a ferry can contain
        /// </value>
        public int PassengerCapacity { get; set; }
        /// <summary>
        /// Property for vehicle capacity
        /// </summary>
        /// <value>
        /// Contains the number of vehicles a ferry can contain
        /// </value>
        public int VehicleCapacity { get; set; }
        /// <summary>
        /// Property for municipality
        /// </summary>
        /// <value>
        /// Contains the name of the municipality which owns the ferry
        /// </value>
        public string Municipality { get; set; }
        /// <summary>
        /// Property for dock
        /// </summary>
        /// <value>
        /// Contains id of the dock the ferry is anchored at, if it is anchored
        /// </value>
        public Dock Dock { get; set; }
    }
}
