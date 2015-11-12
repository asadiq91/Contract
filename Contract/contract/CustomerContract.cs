using Contract.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.contract
{
    public interface CustomerContract
    {
         List<Trip> GetAllTrips();
         List<Reservation> GetAllCustomerReservations(Customer customer);
         bool CreateCustomer(Customer customer);
         Customer GetCustomerByLogin(string username, string password);
         Reservation CreateCustomerReservation(Trip trip, Customer customer, double totalPrice, int numberOfPeople, Vehicle vehicle);
         bool CancelCustomerReservation(Reservation reservation);
    }
}
