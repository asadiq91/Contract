using Contract.contract;
using Contract.dto;
using Contract.eto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for AdminstrationManager
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AdminstrationManager : System.Web.Services.WebService, AdminstrationContract
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Customer CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Customer GetCustomer(string mail)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Customer UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Ferry CreateFerry(Ferry ferry)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Ferry GetFerry(string mail)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Ferry UpdateFerry(Ferry ferry)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteFerry(Ferry ferry)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Trip CreateTrip(Trip trip)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Trip GetTrip(string mail)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Trip UpdateTrip(Trip trip)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteTrip(Trip trip)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Route CreateRoute(Route route)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Route GetRoute(string mail)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Route UpdateRoute(Route route)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteRoute(Route route)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Reservation CreateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Reservation GetReservation(string mail)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Reservation UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Vehicle CreateVehicle(Vehicle Vehicle)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Vehicle GetVehicle(string mail)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Vehicle UpdateVehicle(Vehicle Vehicle)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteVehicle(Vehicle Vehicle)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Dock CreateDock(Dock Dock)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Dock GetDock(string mail)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Dock UpdateDock(Dock Dock)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool DeleteDock(Dock Dock)
        {
            throw new NotImplementedException();
        }
    }
}
