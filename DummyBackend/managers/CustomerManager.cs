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
            return db.TripList;
        }

        public List<Reservation> GetAllCustomerReservations(Customer customer)
        {
            return db.ReservationList.Where(x => x.CustomerId == customer.CustomerId).ToList();
        }

        public bool CreateCustomer(Customer customer)
        {
            db.CustomerList.Add(customer);
            return true;
        }

        public Customer GetCustomerByLogin(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Reservation CreateCustomerReservation(Trip trip, Customer customer, double totalPrice, int numberOfPeople, Vehicle vehicle)
        {
            var reservation = new Reservation {ReservationId = (db.ReservationList.Count+1), CustomerId = customer.CustomerId, TripId = trip.TripId, VehicleId = vehicle.VehicleId, TotalPrice = totalPrice, NumberOfPeople = numberOfPeople };
            db.ReservationList.Add(reservation);
            return reservation;
        }

        public bool CancelCustomerReservation(Reservation reservation)
        {
            return db.ReservationList.Remove(reservation);
        }
    }
}