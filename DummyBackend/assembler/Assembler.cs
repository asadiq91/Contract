using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contract.dto;
using Contract.eto;

namespace DummyBackend.assembler
{
    //NIX PILLE!!!!!!!!!!!!!!!!!!!!!!!!!!!
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

        public List<Customer> AssembleCustomers() 
        {
            return null;
        }

        public List<Ferry> AssembleFerries()
        {
            return null;
        }

        public List<Dock> AssembleDocks()
        {
            var docks = new List<Dock>();
            docks.Add(new Dock { DockId = 1, FerryCapacity = 20, Name = "Ishøj Havn" });
            docks.Add(new Dock { DockId = 2, FerryCapacity = 20, Name = "Vallensbæk Havn" });
            docks.Add(new Dock { DockId = 3, FerryCapacity = 20, Name = "LængereUdePåLandet Havn" });
            docks.Add(new Dock { DockId = 4, FerryCapacity = 20, Name = "Langbortistan Havn" });
            docks.Add(new Dock { DockId = 5, FerryCapacity = 20, Name = "Kharaci Havn" });
            return docks;
        }

        public List<Vehicle> AssembleVehicles()
        {
            var vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle { VehicleId = 1, VehicleSize = 1, VehicleType = "Personbil" });
            vehicles.Add(new Vehicle { VehicleId = 2, VehicleSize = 2, VehicleType = "Varevogn/Mindre lastbil"});
            vehicles.Add(new Vehicle { VehicleId = 3, VehicleSize = 3, VehicleType = "Lastbil" });
            vehicles.Add(new Vehicle { VehicleId = 4, VehicleSize = 4, VehicleType = "Maskine"});
            vehicles.Add(new Vehicle { VehicleId = 5, VehicleSize = 5, VehicleType = "Større maskine" });
            return vehicles;
        }

        public List<Reservation> AssembleReservations()
        {
            return null;
        }

        public List<Route> AssembleRoutes()
        {
            var routes = new List<Route>();
            routes.Add(new Route { RouteId = 1, Depature = "Lyngby", Duration = 90, Destination = "Ishøj"});
            routes.Add(new Route { RouteId = 2, Depature = "Ishøj", Duration = 90, Destination = "Lyngby" });
            routes.Add(new Route { RouteId = 3, Depature = "Langbortistan", Duration = 90, Destination = "Malmø" });
            routes.Add(new Route { RouteId = 4, Depature = "Lyngby", Duration = 90, Destination = "Lübeck" });
            routes.Add(new Route { RouteId = 5, Depature = "Ishøj", Duration = 90, Destination = "Langbortistan" });
            return routes;
        }

        public List<Trip> AssembleTrips()
        {
            return null;
        }


    }
}