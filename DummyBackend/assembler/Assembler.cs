using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract.dto;
using Contract.eto;

namespace DummyBackend.assembler
{
    public class Assembler
    {
        public List<Customer> CustomerList { get; set; }
        public List<Ferry> FerryList { set; get; }
        public List<Dock> DockList { get; set; }
        public List<Vehicle> VehicleList { get; set; }
        public List<Reservation> ReservationList { get; set; }
        public List<Route> RouteList { get; set; }
        public List<Trip> TripList { get; set; }

        public Assembler()
        {
            CustomerList = AssembleCustomers();
            FerryList = AssembleFerries();
            DockList = AssembleDocks();
            VehicleList = AssembleVehicles();
            ReservationList = AssembleReservations();
            RouteList = AssembleRoutes();
            TripList = AssembleTrips();
        }

        private List<Customer> AssembleCustomers()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer { CustomerId = 1, Firstname = "Ahmed", Lastname = "Sadiq", Mail = "mail@mail.dk", Phone = "12345678", Street = "Boulevardgaden" , HouseNumber = "48A", PostalCode = 2635, City = "Ishøj" });
            customers.Add(new Customer { CustomerId = 2, Firstname = "Ahmed", Lastname = "Sadiq", Mail = "mail@mail.dk", Phone = "12345678", Street = "Boulevardgaden" , HouseNumber = "48A", PostalCode = 2635, City = "Ishøj" });
            customers.Add(new Customer { CustomerId = 3, Firstname = "Ahmed", Lastname = "Sadiq", Mail = "mail@mail.dk", Phone = "12345678", Street = "Boulevardgaden" , HouseNumber = "48A", PostalCode = 2635, City = "Ishøj" });
            customers.Add(new Customer { CustomerId = 4, Firstname = "Ahmed", Lastname = "Sadiq", Mail = "mail@mail.dk", Phone = "12345678", Street = "Boulevardgaden" , HouseNumber = "48A", PostalCode = 2635, City = "Ishøj" });
            customers.Add(new Customer { CustomerId = 5, Firstname = "Ahmed", Lastname = "Sadiq", Mail = "mail@mail.dk", Phone = "12345678", Street = "Boulevardgaden" , HouseNumber = "48A", PostalCode = 2635, City = "Ishøj" });
            return customers;
        }

        private List<Ferry> AssembleFerries()
        {
            var ferries = new List<Ferry>();
            ferries.Add(new Ferry { FerryId = 1, DockId = null, Municipality = "Ishøj Kommune", FerryName = "Isabella", PassengerCapacity = 200,VehicleCapacity = 250, FerrySize = "Large"});
            ferries.Add(new Ferry { FerryId = 2, DockId = null, Municipality = "Ishøj Kommune", FerryName = "Monica", PassengerCapacity = 200, VehicleCapacity = 25, FerrySize = "Large" });
            ferries.Add(new Ferry { FerryId = 3, DockId = null, Municipality = "Ishøj Kommune", FerryName = "America", PassengerCapacity = 200, VehicleCapacity = 19, FerrySize = "Large"});
            ferries.Add(new Ferry { FerryId = 4, DockId = null, Municipality = "Ishøj Kommune", FerryName = "Mærsk VI", PassengerCapacity = 200, VehicleCapacity = 0, FerrySize = "Large"});
            ferries.Add(new Ferry { FerryId = 5, DockId = null, Municipality = "Ishøj Kommune", FerryName = "Turan", PassengerCapacity = 200, VehicleCapacity = 5000, FerrySize = "Large"});
            return ferries;
        }

        private List<Dock> AssembleDocks()
        {
            var docks = new List<Dock>();
            docks.Add(new Dock { DockId = 1, FerryCapacity = 20, DockName = "Ishøj Havn" });
            docks.Add(new Dock { DockId = 2, FerryCapacity = 20, DockName = "Vallensbæk Havn" });
            docks.Add(new Dock { DockId = 3, FerryCapacity = 20, DockName = "LængereUdePåLandet Havn" });
            docks.Add(new Dock { DockId = 4, FerryCapacity = 20, DockName = "Langbortistan Havn" });
            docks.Add(new Dock { DockId = 5, FerryCapacity = 20, DockName = "Kharaci Havn" });
            return docks;
        }

        private List<Vehicle> AssembleVehicles()
        {
            var vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle { VehicleId = 1, VehicleSize = 1, VehicleType = "Personbil", VehiclePrice = 200.85 });
            vehicles.Add(new Vehicle { VehicleId = 2, VehicleSize = 2, VehicleType = "Varevogn/Mindre lastbil", VehiclePrice = 253.1 });
            vehicles.Add(new Vehicle { VehicleId = 3, VehicleSize = 3, VehicleType = "Lastbil", VehiclePrice = 1025.5});
            vehicles.Add(new Vehicle { VehicleId = 4, VehicleSize = 4, VehicleType = "Maskine",  VehiclePrice = 2500.8});
            vehicles.Add(new Vehicle { VehicleId = 5, VehicleSize = 5, VehicleType = "Større maskine", VehiclePrice = 5236.8 });
            return vehicles;
        }

        private List<Reservation> AssembleReservations()
        {
            var reservations = new List<Reservation>();
            reservations.Add(new Reservation { ReservationId = 1, CustomerId = 1, NumberOfPeople = 1, TotalPrice = 500, TripId = 1, VehicleId = 1 });
            reservations.Add(new Reservation { ReservationId = 2, CustomerId = 2, NumberOfPeople = 2, TotalPrice = 500, TripId = 2, VehicleId = 2 });
            reservations.Add(new Reservation { ReservationId = 3, CustomerId = 3, NumberOfPeople = 3, TotalPrice = 500, TripId = 3, VehicleId = 3 });
            reservations.Add(new Reservation { ReservationId = 4, CustomerId = 4, NumberOfPeople = 4, TotalPrice = 500, TripId = 4, VehicleId = 4 });
            reservations.Add(new Reservation { ReservationId = 5, CustomerId = 5, NumberOfPeople = 5, TotalPrice = 500, TripId = 5, VehicleId = 5 });
            return reservations;
        }

        private List<Route> AssembleRoutes()
        {
            var routes = new List<Route>();
            routes.Add(new Route { RouteId = 1, Depature = "Lyngby", Duration = 90, Destination = "Ishøj" });
            routes.Add(new Route { RouteId = 2, Depature = "Ishøj", Duration = 90, Destination = "Lyngby" });
            routes.Add(new Route { RouteId = 3, Depature = "Langbortistan", Duration = 90, Destination = "Malmø" });
            routes.Add(new Route { RouteId = 4, Depature = "Lyngby", Duration = 90, Destination = "Lübeck" });
            routes.Add(new Route { RouteId = 5, Depature = "Ishøj", Duration = 90, Destination = "Langbortistan" });
            return routes;
        }

        private List<Trip> AssembleTrips()
        {
            var trips = new List<Trip>();
            trips.Add(new Trip { TripId = 1, DepatureTime = new DateTime(2015, 04, 12, 21, 45, 00), RouteId = 1, FerryId = 1, TripPrice = 100 });
            trips.Add(new Trip { TripId = 2, DepatureTime = new DateTime(2015, 11, 12, 12, 55, 00), RouteId = 2, FerryId = 2, TripPrice = 120 });
            trips.Add(new Trip { TripId = 3, DepatureTime = new DateTime(2015, 07, 12, 14, 30, 00), RouteId = 3, FerryId = 3, TripPrice = 100 });
            trips.Add(new Trip { TripId = 4, DepatureTime = new DateTime(2015, 12, 12, 02, 10, 00), RouteId = 4, FerryId = 4, TripPrice = 150 });
            trips.Add(new Trip { TripId = 5, DepatureTime = new DateTime(2015, 01, 12, 10, 18, 00), RouteId = 5, FerryId = 5, TripPrice = 119 });
            return trips;
        }


    }
}