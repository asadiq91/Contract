using Contract.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.contract
{
    /// <summary>
    /// Interface for Administration Contract
    /// </summary>
    public interface AdminstrationContract
    {

        //Customer
        /// <summary>
        /// Create customer
        /// </summary>
        /// <param name="customer">The customer object</param>
        /// <returns>The saved customer oject?</returns>
        Customer CreateCustomer(Customer customer);
        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="mail">The search parameter</param>
        /// <returns>The customer</returns>
        /// <exception cref="eto.CustomerNotFoundException">Thrown if the customer was not found</exception>
        Customer GetCustomer(string mail);
        /// <summary>
        /// Update a customer
        /// </summary>
        /// <param name="customer">The customer object</param>
        /// <returns>The updated customer object?</returns>
        /// <exception cref="eto.CustomerNotFoundException">Thrown if the customer was not found</exception>
        Customer UpdateCustomer(Customer customer);
        /// <summary>
        /// Delete a customer
        /// </summary>
        /// <param name="customer">The customer object</param>
        /// <returns>True if successful, false if not</returns>
        /// <exception cref="eto.CustomerNotFoundException">Thrown if the customer was not found</exception>
        bool DeleteCustomer(Customer customer);
        //Ferry
        /// <summary>
        /// Create a ferry
        /// </summary>
        /// <param name="ferry">The ferry object</param>
        /// <returns>The created ferry object?</returns>
        Ferry CreateFerry(Ferry ferry);
        /// <summary>
        /// Get a ferry
        /// </summary>
        /// <param name="mail">The email of the ferry?</param>
        /// <returns>The ferry</returns>
        /// <exception cref="eto.FerryNotFoundException">Thrown if the ferry was not found</exception>
        Ferry GetFerry(string mail);
        /// <summary>
        /// Update a ferry
        /// </summary>
        /// <param name="ferry">The ferry to update</param>
        /// <returns>The updated ferry</returns>
        /// <exception cref="eto.FerryNotFoundException">Thrown if the ferry was not found</exception>
        Ferry UpdateFerry(Ferry ferry);
        /// <summary>
        /// Delete a ferry
        /// </summary>
        /// <param name="ferry">The ferry to delete</param>
        /// <returns>True if successful, false if not</returns>
        /// <exception cref="eto.FerryNotFoundException">Thrown if the ferry was not found</exception>
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
