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
    public class AdminstrationManager : AdminstrationContract
    {
        Assembler db;

        public AdminstrationManager()
        {
            db = new Assembler();
        }

        public Customer CreateCustomer(Customer customer)
        {
            db.CustomerList.Add(customer);
            return customer;
        }

        public Customer GetCustomer(string mail)
        {
            return db.CustomerList.Single(x => x.Mail == mail);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var old = db.CustomerList.Single(x => x.CustomerId == customer.CustomerId);
            db.CustomerList[db.CustomerList.IndexOf(old)] = customer;
            return customer;
        }

        public bool DeleteCustomer(Customer customer)
        {
            return db.CustomerList.Remove(customer);
        }

        public Ferry CreateFerry(Ferry ferry)
        {
            db.FerryList.Add(ferry);
            return ferry;
        }

        public Ferry GetFerry(int ferryId)
        {
            return db.FerryList.Single(x => x.FerryId == ferryId);
        }

        public Ferry UpdateFerry(Ferry ferry)
        {
            var old = db.FerryList.Single(x => x.FerryId == ferry.FerryId);
            db.FerryList[db.FerryList.IndexOf(old)] = ferry;
            return ferry;
        }

        public bool DeleteFerry(Ferry ferry)
        {
            return db.FerryList.Remove(ferry);
        }

        public Trip CreateTrip(Trip trip)
        {
            db.TripList.Add(trip);
            return trip;
        }

        public Trip GetTrip(int tripId)
        {
            return db.TripList.Single(x => x.TripId == tripId);
        }

        public Trip UpdateTrip(Trip trip)
        {
            var old = db.TripList.Single(x => x.TripId == trip.TripId);
            db.TripList[db.TripList.IndexOf(old)] = trip;
            return trip;
        }

        public bool DeleteTrip(Trip trip)
        {
            return db.TripList.Remove(trip);
        }

        public Route CreateRoute(Route route)
        {
            db.RouteList.Add(route);
            return route;
        }

        public Route GetRoute(int routeId)
        {
            return db.RouteList.Single(x => x.RouteId == routeId);
        }

        public Route UpdateRoute(Route route)
        {
            var old = db.RouteList.Single(x => x.RouteId == route.RouteId);
            db.RouteList[db.RouteList.IndexOf(old)] = route;
            return route;
        }

        public bool DeleteRoute(Route route)
        {
            return db.RouteList.Remove(route);
        }

        public Reservation CreateReservation(Reservation reservation)
        {
            db.ReservationList.Add(reservation);
            return reservation;
        }

        public Reservation GetReservation(int reservationId)
        {
            return db.ReservationList.Single(x => x.ReservationId == reservationId);
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            var old = db.ReservationList.Single(x => x.ReservationId == reservation.ReservationId);
            db.ReservationList[db.ReservationList.IndexOf(old)] = reservation;
            return reservation;
        }

        public bool DeleteReservation(Reservation reservation)
        {
            return db.ReservationList.Remove(reservation);
        }

        public Vehicle CreateVehicle(Vehicle vehicle)
        {
            db.VehicleList.Add(vehicle);
            return vehicle;
        }

        public Vehicle GetVehicle(int vehicleId)
        {
            return db.VehicleList.Single(x => x.VehicleId == vehicleId);
        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            var old = db.VehicleList.Single(x => x.VehicleId == vehicle.VehicleId);
            db.VehicleList[db.VehicleList.IndexOf(old)] = vehicle;
            return vehicle;
        }

        public bool DeleteVehicle(Vehicle vehicle)
        {
            return db.VehicleList.Remove(vehicle);
        }

        public Dock CreateDock(Dock dock)
        {
            db.DockList.Add(dock);
            return dock;
        }

        public Dock GetDock(int dockId)
        {
            return db.DockList.Single(x => x.DockId == dockId);
        }

        public Dock UpdateDock(Dock dock)
        {
            var old = db.DockList.Single(x => x.DockId == dock.DockId);
            db.DockList[db.DockList.IndexOf(old)] = dock;
            return dock;
        }

        public bool DeleteDock(Dock dock)
        {
            return db.DockList.Remove(dock);
        }

        public List<Customer> GetAllCustomer()
        {
            return db.CustomerList;
        }

        public List<Ferry> GetAllFerries()
        {
            return db.FerryList;
        }

        public List<Route> GetAllRoutes()
        {
            return db.RouteList;
        }

        public List<Reservation> GetAllReservations()
        {
            return db.ReservationList;
        }

        public List<Trip> GetAllTrips()
        {
            return db.TripList;
        }

        public List<Vehicle> GetAllVehicles()
        {
            return db.VehicleList;
        }

        public List<Dock> GetAllDocks()
        {
            return db.DockList;
        }
    }
}