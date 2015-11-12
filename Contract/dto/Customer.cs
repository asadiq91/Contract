using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public bool Native { get; set; }
        public int AmountOfFreeRides { get; set; }
    }
}
