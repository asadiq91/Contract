using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract.contract;
using Contract.dto;
using Contract.eto;
using DummyBackend.assembler;

namespace DummyBackend.managers
{
    //NIX PILLE!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public class CustomerManager : CustomerContract
    {
        Assembler db;

        public CustomerManager(){
            db = new Assembler();
        }

        public List<Trip> GetAllTrips()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAllCustomerReservations(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByLogin(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Reservation CreateCustomerReservation(Trip trip, Customer customer, double totalPrice, int numberOfPeople, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public bool CancelCustomerReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}