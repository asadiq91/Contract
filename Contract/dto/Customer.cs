using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    /// <summary>
    /// Customer object
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Property for CustomerId
        /// </summary>
        /// <value>
        /// Contains customers unique id
        /// </value>
        public int CustomerId { get; set; }
        /// <summary>
        /// Property for customers firstname
        /// </summary>
        /// <value>
        /// Contains customers firstname
        /// </value>
        public string Firstname { get; set; }
        /// <summary>
        /// Property for customers lastname
        /// </summary>
        /// <value>
        /// Contains customers lastname
        /// </value>
        public string Lastname { get; set; }
        /// <summary>
        /// Property for customers phone number
        /// </summary>
        /// <value>
        /// Contains customers phone number
        /// </value>
        public string Phone { get; set; }
        /// <summary>
        /// Property for customers email
        /// </summary>
        /// <value>
        /// Contains customers email
        /// </value>
        public string Mail { get; set; }
        /// <summary>
        /// Property for street
        /// </summary>
        /// <value>
        /// Contains street name of customers address
        /// </value>
        public string Street { get; set; }
        /// <summary>
        /// Property for house number
        /// </summary>
        /// <value>
        /// Contains house number of customers address
        /// </value>
        public string HouseNumber { get; set; }
        /// <summary>
        /// Property for postal code
        /// </summary>
        /// <value>
        /// Contains postal code of customers city
        /// </value>
        public int PostalCode { get; set; }
        /// <summary>
        /// Property for city
        /// </summary>
        /// <value>
        /// Contains customers city
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Property for native
        /// </summary>
        /// <value>
        /// Contains true if customer is native or false
        /// </value>
        public bool Native { get; set; }
        /// <summary>
        /// Property for amount of free rides
        /// </summary>
        /// <value>
        /// Contains the amount of free rides the customer has
        /// </value>
        public int AmountOfFreeRides { get; set; }
    }
}
