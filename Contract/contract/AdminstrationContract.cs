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
        /// <returns>The saved customer object</returns>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Customer object are missing</exception>
        Customer CreateCustomer(Customer customer);
        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="mail">The search parameter</param>
        /// <returns>The customer</returns>
        /// <exception cref="eto.CustomerNotFoundException">Thrown if the customer was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if mail parameter isn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if mail parameter is missing</exception>
        Customer GetCustomer(string mail);
        /// <summary>
        /// Update a customer
        /// </summary>
        /// <param name="customer">The customer object</param>
        /// <returns>The updated customer object</returns>
        /// <exception cref="eto.CustomerNotFoundException">Thrown if the customer was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Customer object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Customer object are missing</exception>
        Customer UpdateCustomer(Customer customer);
        /// <summary>
        /// Delete a customer
        /// </summary>
        /// <param name="customer">The customer object</param>
        /// <returns>true if successful, false if not</returns>
        /// <exception cref="eto.CustomerNotFoundException">Thrown if the customer was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Customer object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Customer object are missing</exception>
        bool DeleteCustomer(Customer customer);
        //Ferry
        /// <summary>
        /// Create a ferry
        /// </summary>
        /// <param name="ferry">The ferry object</param>
        /// <returns>The created ferry object</returns>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Ferry object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Ferry object are missing</exception>
        Ferry CreateFerry(Ferry ferry);
        /// <summary>
        /// Get a ferry
        /// </summary>
        /// <param name="ferryId">The identifier of the ferry</param>
        /// <returns>The ferry</returns>
        /// <exception cref="eto.FerryNotFoundException">Thrown if the ferry was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if the parameter ferryId isn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some the parameter ferryId is missing</exception>
        Ferry GetFerry(int ferryId);
        /// <summary>
        /// Update a ferry
        /// </summary>
        /// <param name="ferry">The ferry to update</param>
        /// <returns>The updated ferry</returns>
        /// <exception cref="eto.FerryNotFoundException">Thrown if the ferry was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Ferry object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Ferry object are missing</exception>
        Ferry UpdateFerry(Ferry ferry);
        /// <summary>
        /// Delete a ferry
        /// </summary>
        /// <param name="ferry">The ferry to delete</param>
        /// <returns>true if successful, false if not</returns>
        /// <exception cref="eto.FerryNotFoundException">Thrown if the ferry was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Ferry object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Ferry object are missing</exception>
        bool DeleteFerry(Ferry ferry);
        //Trip
        /// <summary>
        /// Create trip
        /// </summary>
        /// <param name="trip">The Trip object</param>
        /// <returns>The saved Trip object</returns>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Trip object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Trip object are missing</exception>
        Trip CreateTrip(Trip trip);
        /// <summary>
        /// Get a trip
        /// </summary>
        /// <param name="tripId">The identifier of the trip</param>
        /// <returns>The trip</returns>
        /// <exception cref="eto.TripNotFoundException">Thrown if the trip was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if the parameter tripId isn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some the parameter tripId is missing</exception>
        Trip GetTrip(int tripId);
        /// <summary>
        /// Update a trip
        /// </summary>
        /// <param name="trip">The trip to update</param>
        /// <returns>The updated trip</returns>
        /// <exception cref="eto.TripNotFoundException">Thrown if the trip was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Trip object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Trip object are missing</exception>
        Trip UpdateTrip(Trip trip);
        /// <summary>
        /// Delete a trip
        /// </summary>
        /// <param name="trip">The trip to delete</param>
        /// <returns>true if successful, false if not</returns>
        /// <exception cref="eto.TripNotFoundException">Thrown if the trip was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Trip object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Trip object are missing</exception>
        bool DeleteTrip(Trip trip);
        //Route
        /// <summary>
        /// Create trip
        /// </summary>
        /// <param name="route">The Route object</param>
        /// <returns>The saved Route object</returns>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Route object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Route object are missing</exception>
        Route CreateRoute(Route route);
        /// <summary>
        /// Get a route
        /// </summary>
        /// <param name="routeId">The identifier of the route</param>
        /// <returns>The route</returns>
        /// <exception cref="eto.RouteNotFoundException">Thrown if the route was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if the parameter routeId isn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some the parameter routeId is missing</exception>
        Route GetRoute(int routeId);
        /// <summary>
        /// Update a route
        /// </summary>
        /// <param name="route">The route to update</param>
        /// <returns>The updated route</returns>
        /// <exception cref="eto.RouteNotFoundException">Thrown if the route was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Route object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Route object are missing</exception>
        Route UpdateRoute(Route route);
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <param name="route">The route to delete</param>
        /// <returns>true if successful, false if not</returns>
        /// <exception cref="eto.RouteNotFoundException">Thrown if the route was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Route object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Route object are missing</exception>
        bool DeleteRoute(Route route);
        //Reservation
        /// <summary>
        /// Create reservation
        /// </summary>
        /// <param name="reservation">The Reservation object</param>
        /// <returns>The saved Reservation object</returns>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Reservation object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Reservation object are missing</exception>
        Reservation CreateReservation(Reservation reservation);
        /// <summary>
        /// Get a reservation
        /// </summary>
        /// <param name="reservationId">The identifier of the reservation</param>
        /// <returns>The reservation</returns>
        /// <exception cref="eto.ReservationNotFoundException">Thrown if the reservation was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if the parameter reservationId isn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some the parameter reservationId is missing</exception>
        Reservation GetReservation(int reservationId);
        /// <summary>
        /// Update a reservation
        /// </summary>
        /// <param name="reservation">The reservation to update</param>
        /// <returns>The updated reservation</returns>
        /// <exception cref="eto.ReservationNotFoundException">Thrown if the reservation was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Reservation object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Reservation object are missing</exception>
        Reservation UpdateReservation(Reservation reservation);
        /// <summary>
        /// Delete a reservation
        /// </summary>
        /// <param name="reservation">The reservation to delete</param>
        /// <returns>true if successful, false if not</returns>
        /// <exception cref="eto.ReservationNotFoundException">Thrown if the reservation was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Reservation object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Reservation object are missing</exception>
        bool DeleteReservation(Reservation reservation);
        //Vehicle
        /// <summary>
        /// Create vehicle
        /// </summary>
        /// <param name="vehicle">The Vehicle object</param>
        /// <returns>The saved Vehicle object</returns>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Vehicle object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Vehicle object are missing</exception>
        Vehicle CreateVehicle(Vehicle Vehicle);
        /// <summary>
        /// Get a vehicle
        /// </summary>
        /// <param name="vehicleId">The identifier of the vehicle</param>
        /// <returns>The vehicle</returns>
        /// <exception cref="eto.VehicleNotFoundException">Thrown if the vehicle was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if the parameter vehicleId isn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some the parameter vehicleId is missing</exception>
        Vehicle GetVehicle(int vehicleId);
        /// <summary>
        /// Update a vehicle
        /// </summary>
        /// <param name="vehicle">The vehicle to update</param>
        /// <returns>The updated vehicle</returns>
        /// <exception cref="eto.VehicleNotFoundException">Thrown if the vehicle was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Vehicle object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Vehicle object are missing</exception>
        Vehicle UpdateVehicle(Vehicle Vehicle);
        /// <summary>
        /// Delete a vehicle
        /// </summary>
        /// <param name="vehicle">The vehicle to delete</param>
        /// <returns>true if successful, false if not</returns>
        /// <exception cref="eto.VehicleNotFoundException">Thrown if the vehicle was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Vehicle object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Vehicle object are missing</exception>
        bool DeleteVehicle(Vehicle Vehicle);
        //Dock
        /// <summary>
        /// Create dock
        /// </summary>
        /// <param name="dock">The Dock object</param>
        /// <returns>The saved Dock object</returns>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Dock object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Dock object are missing</exception>
        Dock CreateDock(Dock Dock);
        /// <summary>
        /// Get a dock
        /// </summary>
        /// <param name="dockId">The identifier of the dock</param>
        /// <returns>The dock</returns>
        /// <exception cref="eto.DockNotFoundException">Thrown if the dock was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if the parameter dockId isn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some the parameter dockId is missing</exception>
        Dock GetDock(int dockId);
        /// <summary>
        /// Update a dock
        /// </summary>
        /// <param name="dock">The dock to update</param>
        /// <returns>The updated dock</returns>
        /// <exception cref="eto.DockNotFoundException">Thrown if the dock was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Dock object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Dock object are missing</exception>
        Dock UpdateDock(Dock Dock);
        /// <summary>
        /// Delete a dock
        /// </summary>
        /// <param name="dock">The dock to delete</param>
        /// <returns>true if successful, false if not</returns>
        /// <exception cref="eto.DockNotFoundException">Thrown if the dock was not found</exception>
        /// <exception cref="eto.IllegalParameterException">Thrown if some parameters in the Dock object arn't in correct format</exception>
        /// <exception cref="eto.MissingParameterException">Thrown if some parameters in the Dock object are missing</exception>
        bool DeleteDock(Dock Dock);
        /// <summary>
        /// Get a list of all customers
        /// </summary>
        /// <returns>List of all customers</returns>
        List<Customer> GetAllCustomer();
        /// <summary>
        /// Get a list of all ferries
        /// </summary>
        /// <returns>List of all ferries</returns>
        List<Ferry> GetAllFerries();
        /// <summary>
        /// Get a list of all routes
        /// </summary>
        /// <returns>List of all routes</returns>
        List<Route> GetAllRoutes();
        /// <summary>
        /// Get a list of all reservations
        /// </summary>
        /// <returns>List of all reservations</returns>
        List<Reservation> GetAllReservations();
        /// <summary>
        /// Get a list of all trips
        /// </summary>
        /// <returns>List of all trips</returns>
        List<Trip> GetAllTrips();
        /// <summary>
        /// Get a list of all vehicles
        /// </summary>
        /// <returns>List of all vehicles</returns>
        List<Vehicle> GetAllVehicles();
        /// <summary>
        /// Get a list of all docks
        /// </summary>
        /// <returns>List of all docks</returns>
        List<Dock> GetAllDocks();
    }
}
