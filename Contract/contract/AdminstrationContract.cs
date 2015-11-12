using Contract.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.contract
{
    public interface AdminstrationContract
    {

        //Customer
         Customer CreateCustomer(Customer customer);
         Customer GetCustomer(string mail);
         Customer UpdateCustomer(Customer customer);
         bool DeleteCustomer(Customer customer);
        //Ferry
         Ferry CreateFerry(Ferry ferry);
         Ferry GetFerry(string mail);
         Ferry UpdateFerry(Ferry ferry);
         bool DeleteFerry(Ferry ferry);
        //Trip
         Trip CreateTrip(Trip trip);
         Trip GetTrip(string mail);
         Trip UpdateTrip(Trip trip);
         bool DeleteTrip(Trip trip);
        //Route
         Route CreateRoute(Route route);
         Route GetRoute(string mail);
         Route UpdateRoute(Route route);
         bool DeleteRoute(Route route);
        //Reservation
         Reservation CreateReservation(Reservation reservation);
         Reservation GetReservation(string mail);
         Reservation UpdateReservation(Reservation reservation);
         bool DeleteReservation(Reservation reservation);
        //Vehicle
         Vehicle CreateVehicle(Vehicle Vehicle);
         Vehicle GetVehicle(string mail);
         Vehicle UpdateVehicle(Vehicle Vehicle);
         bool DeleteVehicle(Vehicle Vehicle);
        //Dock
         Dock CreateDock(Dock Dock);
         Dock GetDock(string mail);
         Dock UpdateDock(Dock Dock);
         bool DeleteDock(Dock Dock);
    }
}
