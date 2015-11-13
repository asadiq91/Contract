using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.contract;
using Contract.dto;
using Contract.eto;

namespace UnitTest.Vertical
{
    /// <summary>
    /// Stub for interface Contract.contract.CustomerContract
    /// </summary>
    class CustomerInterfaceStub : Contract.contract.CustomerContract
    {
        public bool CancelCustomerReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public bool CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Reservation CreateCustomerReservation(Trip trip, Customer customer, double totalPrice, int numberOfPeople, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAllCustomerReservations(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetAllTrips()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByLogin(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
