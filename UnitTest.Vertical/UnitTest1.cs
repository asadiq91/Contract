using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Contract.contract;
using Contract.dto;
using Contract.eto;

namespace UnitTest.Vertical
{
    /// <summary>
    /// Note: Backend made this test, making educated guesses reguarding usage of exceptions.
    /// XML documentation missing from Contract project
    /// </summary>
    [TestClass]
    public class UnitTest1
    {

        private CustomerContract getCustomerContract()
        {
            return new CustomerInterfaceStub();
        }

        private AdminstrationContract getAdministrationContract()
        {
            return new AdministratorInterfaceStub();
        }

        #region Tests for CustomerContract

        [TestMethod]
        public void CustomerContractGetAllTrips()
        {
            List<Trip> tripList = null;
            CustomerContract cis = getCustomerContract();
            // Question: We dont know if the frontend wants us to thrown any specific
            tripList = cis.GetAllTrips();
            if (tripList == null)
                Assert.Fail("GetAllTrips return a null");
            Assert.AreNotEqual(0, tripList.Count);
        }

        [TestMethod]
        public void CustomerContractGetAllCustomerReservations()
        {
            List<Reservation> resList = new List<Reservation>();
            CustomerContract cis = getCustomerContract();
            Customer cust = new Customer()
            {
                CustomerId = 1
            };
            try
            {
                resList = cis.GetAllCustomerReservations(cust);
            }
            catch (CustomerNotFoundException)
            {
                Assert.Fail("Invalid customer");
            }
            Assert.AreNotEqual(0, resList);
        }

        [TestMethod]
        public void CustomerContractCreateCustomer()
        {
            CustomerContract cis = getCustomerContract();
            Customer cust = new Customer()
            {
                CustomerId = 1
            };
            bool result = false;
            try
            {
                result = cis.CreateCustomer(cust);
            }
            catch (CustomerNotFoundException)
            {
                Assert.Fail("CustomerNotFoundException");
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CustomerContractCreateCustomerReservation()
        {
            CustomerContract cis = getCustomerContract();
            AdminstrationContract ais = getAdministrationContract();

            // Question: This will be a long list after a few days. A parameter to indicate route and/or date and time?
            List<Trip> tripList = cis.GetAllTrips();

            Trip trip = tripList[0];

            //Question: So the CustomerFrontend saves the username and password... That sound extremly safe.. maybe use the email since that should be unique?
            Customer customer = cis.GetCustomerByLogin("anders", "and");

            double totalPrice = 500.00;
            int numberOfPeople = 2000;

            Vehicle vehicle = ais.GetVehicle(1);


            Reservation reservation = null;
            try
            {
                reservation = cis.CreateCustomerReservation(trip, customer, totalPrice, numberOfPeople, vehicle);
            }
            catch (TripNotFoundException ex)
            {
                Assert.Fail("Trip not found: " + ex.Message);
            }
            catch (CustomerNotFoundException ex)
            {
                Assert.Fail("Customer not found: " + ex.Message);
            }
            catch (VehicleNotFoundException ex)
            {
                Assert.Fail("Vehicle not found: " + ex.Message);
            }

            Assert.IsNotNull(reservation);
        }

        [TestMethod]
        public void CustomerCancelCustomerReservation()
        {
            //Question:  This would be so much simpler if we had a GetReservation(int reservationid)
            CustomerContract cis = getCustomerContract();
            List<Reservation> resList = null;
            Customer cust = new Customer()
            {
                CustomerId = 1
            };
            try
            {
                resList = cis.GetAllCustomerReservations(cust);
            }
            catch (CustomerNotFoundException)
            {
                Assert.Fail("Invalid customer");
            }
            if (resList == null)
                Assert.Fail("Could not find a valid reservation for customer.customerid=1");
            else
            {
                if (resList.Count == 0)
                {
                    Assert.Fail("Could not find a valid reservation for customer.customerid=1");
                }
                else
                {
                    int oldCount = resList.Count;
                    cis.CancelCustomerReservation(resList[0]);

                    try
                    {
                        resList = cis.GetAllCustomerReservations(cust);
                    }
                    catch (CustomerNotFoundException)
                    {
                        Assert.Fail("Invalid customer");
                    }

                    Assert.AreNotEqual(oldCount, resList.Count);
                }
            }

        }
        #endregion

        #region Tests for AdminstrationContract

        /*
            Question: 
            Backend: Not sure what to test in the Create-methods. Should there be a difference between the parameter and the return value?
            Should we return an object so the frontend gets the id?

            And why do all Get-methods have email as parameter? 
        */

        [TestMethod]
        public void AdminstrationContractCreateCustomer()
        {
            AdminstrationContract ais = getAdministrationContract();

            Customer newCustomer = new Customer()
            {
                CustomerId = 1,
                Mail = "anders@and.com"
            };

            //Question:  Backend question: What do we do if this fails? return null or some random exception?
            Customer returnValue = ais.CreateCustomer(newCustomer);

            Assert.AreEqual<Customer>(newCustomer, returnValue);
        }

        [TestMethod]
        public void AdminstrationContractGetCustomer()
        {
            AdminstrationContract ais = getAdministrationContract();
            Customer customer = null;
            try
            {
                customer = ais.GetCustomer("anders@and.com");
            }
            catch (CustomerNotFoundException ex)
            {
                Assert.Fail("CustomerNotFoundException: " + ex.Message);
            }
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void AdminstrationContractUpdateCustomer()
        {
            AdminstrationContract ais = getAdministrationContract();
            Customer customer = ais.GetCustomer("anders@and.com");
            int oldValue = customer.AmountOfFreeRides;
            customer.AmountOfFreeRides = customer.AmountOfFreeRides + 1;
            try
            {
                customer = ais.UpdateCustomer(customer);
            }
            catch (CustomerNotFoundException ex)
            {
                Assert.Fail("CustomerNotFoundException: " + ex.Message);
            }

            Assert.AreEqual(oldValue + 1, customer.AmountOfFreeRides);
        }

        [TestMethod]
        public void AdminstrationContractDeleteCustomer()
        {
            AdminstrationContract ais = getAdministrationContract();
            Customer customer = ais.GetCustomer("anders@and.com");
            try
            {
                ais.DeleteCustomer(customer);
            }
            catch (CustomerNotFoundException ex)
            {
                Assert.Fail("CustomerNotFoundException: " + ex.Message);
            }
            try
            {
                customer = ais.GetCustomer("anders@and.com");
            }
            catch (CustomerNotFoundException ex)
            {
                customer = null;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            Assert.IsNull(customer);
        }

        [TestMethod]
        public void AdminstrationContractCreateFerry()
        {
            AdminstrationContract ais = getAdministrationContract();
            Ferry newFerry = new Ferry()
            {
                DockId = 1, //Question:  What is this? A secret class?
                FerryId = 1,
                Municipality = "Andeby",
                Name = "Hugo",
                PassengerCapacity = 7,
                Size = "VERY BIG"
            };
            //Question:  Backend: Since we have no exceptions in eto to throw, we just return null if something went wrong?
            Ferry returnValue = ais.CreateFerry(newFerry);

            Assert.AreEqual<Ferry>(newFerry, returnValue);
        }

        [TestMethod]
        public void AdminstrationContractGetFerry()
        {
            AdminstrationContract ais = getAdministrationContract();


            Ferry newFerry = null;
            try
            {
                //Question: Backend: So a ferry have an email? 
                //Its missing in the DTO... 
                //so we cant save it. 
                //you can create millions of ferrys, but GetFerry will always fail...
                newFerry = ais.GetFerry(1);
            }
            catch (FerryNotFoundException ex)
            {
                Assert.Fail("FerryNotFoundException: " + ex.Message);
            }
            Assert.IsNotNull(newFerry);
        }

        [TestMethod]
        public void AdminstrationContractUpdateFerry()
        {
            AdminstrationContract ais = getAdministrationContract();


            Ferry newFerry = null;
            try
            {
                //Question: Backend: So a ferry have an email? 
                //Its missing in the DTO... 
                //so we cant save it. 
                //you can create millions of ferrys, but GetFerry will always fail...
                newFerry = ais.GetFerry(1);
            }
            catch (FerryNotFoundException ex)
            {
                Assert.Fail("FerryNotFoundException: " + ex.Message);
            }
            int oldValue = newFerry.PassengerCapacity;
            newFerry.PassengerCapacity++;
            Ferry returnValue = ais.UpdateFerry(newFerry);

            Assert.AreEqual(oldValue + 1, returnValue.PassengerCapacity);
        }

        [TestMethod]
        public void AdminstrationContractDeleteFerry()
        {
            AdminstrationContract ais = getAdministrationContract();
            Ferry newFerry = ais.GetFerry(1);
            bool result = false;
            try
            {
                result = ais.DeleteFerry(newFerry);
            }
            catch (FerryNotFoundException)
            {
                Assert.Fail("FerryNotFoundException");
            }
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void AdminstrationContractCreateReservation()
        {
            AdminstrationContract ais = getAdministrationContract();

            Reservation reservation = new Reservation()
            {
                TripId = 1,
                CustomerId = 1,
                NumberOfPeople = 900,
                ReservationId = 43,
                TotalPrice = 500000.47,
                VehicleId = 12
            };

            Reservation resultReservation = null;
            try
            {
                resultReservation = ais.CreateReservation(reservation);
            }
            catch (CustomerNotFoundException)
            {
                Assert.Fail("CustomerNotFoundException");
            }
            catch (TripNotFoundException)
            {
                Assert.Fail("TripNotFoundException");
            }
            catch (VehicleNotFoundException)
            {
                Assert.Fail("VehicleNotFoundException");
            }

            Assert.AreEqual<Reservation>(reservation, resultReservation);
        }

        [TestMethod]
        public void AdminstrationContractGetReservation()
        {
            AdminstrationContract ais = getAdministrationContract();

            Reservation reservation = null;
            try
            {
                reservation = ais.GetReservation(1);
            }
            catch (ReservationNotFoundException)
            {
                Assert.Fail("ReservationNotFoundException");
            }

            Assert.IsNotNull(reservation);

        }

        [TestMethod]
        public void AdminstrationContractUpdateReservation()
        {
            AdminstrationContract ais = getAdministrationContract();

            Reservation reservation = null;
            try
            {
                reservation = ais.GetReservation(1);
            }
            catch (ReservationNotFoundException)
            {
                Assert.Fail("ReservationNotFoundException");
            }
            reservation.TotalPrice++;
            Reservation resultReservation = null;
            try
            {
                resultReservation = ais.UpdateReservation(reservation);
            }
            catch (ReservationNotFoundException)
            {
                Assert.Fail("ReservationNotFoundException");
            }
            Assert.AreEqual(reservation.TotalPrice, resultReservation.TotalPrice);
        }

        [TestMethod]
        public void AdminstrationContractDeleteReservation()
        {
            AdminstrationContract ais = getAdministrationContract();

            Reservation reservation = null;
            try
            {
                reservation = ais.GetReservation(1);
            }
            catch (ReservationNotFoundException)
            {
                Assert.Fail("ReservationNotFoundException");
            }

            bool result = false;
            try
            {
                result = ais.DeleteReservation(reservation);
            }
            catch (ReservationNotFoundException)
            {
                Assert.Fail("ReservationNotFoundException");
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdminstrationContractCreateTrip()
        {
            AdminstrationContract ais = getAdministrationContract();

            Trip trip = new Trip()
            {
                FerryId = 1,
                Price = 2.25,
                RouteId = 1,
                TripId = 1
            };

            Trip returnTrip = null;
            try
            {
                returnTrip = ais.CreateTrip(trip);
            }
            catch (FerryNotFoundException)
            {
                Assert.Fail("FerryNotFoundException");
            }
            catch (RouteNotFoundException)
            {
                Assert.Fail("RouteNotFoundException");
            }

            Assert.AreEqual<Trip>(trip, returnTrip);
        }

        [TestMethod]
        public void AdminstrationContractGetTrip()
        {
            AdminstrationContract ais = getAdministrationContract();
            Trip trip = null;
            try
            {
                trip = ais.GetTrip(1);
            }
            catch (TripNotFoundException)
            {
                Assert.Fail("TripNotFoundException");
            }
            Assert.IsNotNull(trip);
        }

        [TestMethod]
        public void AdminstrationContractUpdateTrip()
        {
            AdminstrationContract ais = getAdministrationContract();
            Trip trip = null;
            try
            {
                trip = ais.GetTrip(1);
            }
            catch (TripNotFoundException)
            {
                Assert.Fail("TripNotFoundException");
            }

            trip.Price++;
            Trip returnTrip = null;
            try
            {
                returnTrip = ais.UpdateTrip(trip);
            }
            catch (TripNotFoundException)
            {
                Assert.Fail("TripNotFoundException");
            }

            Assert.AreEqual<Trip>(trip, returnTrip);
        }

        [TestMethod]
        public void AdminstrationContractDeleteTrip()
        {
            AdminstrationContract ais = getAdministrationContract();
            Trip trip = null;
            try
            {
                trip = ais.GetTrip(1);
            }
            catch (TripNotFoundException)
            {
                Assert.Fail("TripNotFoundException");
            }
            bool result = false;
            try
            {
                result = ais.DeleteTrip(trip);
            }
            catch (TripNotFoundException)
            {
                Assert.Fail("TripNotFoundException");
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdminstrationContractCreateVehicle()
        {
            AdminstrationContract ais = getAdministrationContract();

            Vehicle vehicle = new Vehicle()
            {
                VehicleId = 1,
                VehicleSize = 1,
                VehicleType = "M109"
            };

            Vehicle returnVehicle = null;
            returnVehicle = ais.CreateVehicle(vehicle);

            Assert.AreEqual<Vehicle>(vehicle, returnVehicle);

        }

        [TestMethod]
        public void AdminstrationContractGetVehicle()
        {
            AdminstrationContract ais = getAdministrationContract();
            Vehicle item = null;
            try
            {
                item = ais.GetVehicle(1);
            }
            catch (VehicleNotFoundException)
            {
                Assert.Fail("VehicleNotFoundException");
            }
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void AdminstrationContractUpdateVehicle()
        {
            AdminstrationContract ais = getAdministrationContract();
            Vehicle item = null;
            try
            {
                item = ais.GetVehicle(1);
            }
            catch (VehicleNotFoundException)
            {
                Assert.Fail("VehicleNotFoundException");
            }

            item.VehicleSize++;
            Vehicle returnItem = null;
            try
            {
                returnItem = ais.UpdateVehicle(item);
            }
            catch (VehicleNotFoundException)
            {
                Assert.Fail("VehicleNotFoundException");
            }

            Assert.AreEqual(item.VehicleSize, returnItem.VehicleSize);
        }

        [TestMethod]
        public void AdminstrationContractDeleteVehicle()
        {
            AdminstrationContract ais = getAdministrationContract();
            Vehicle item = null;
            try
            {
                item = ais.GetVehicle(1);
            }
            catch (VehicleNotFoundException)
            {
                Assert.Fail("VehicleNotFoundException");
            }
            bool returnValue = false;
            try
            {
                returnValue = ais.DeleteVehicle(item);
            }
            catch (VehicleNotFoundException)
            {
                Assert.Fail("VehicleNotFoundException");
            }
            Assert.IsTrue(returnValue);
        }

        [TestMethod]
        public void AdminstrationContractCreateRoute()
        {
            AdminstrationContract ais = getAdministrationContract();
            //Question:  So where do we Depart FROM?
            Route item = new Route()
            {
                Depature = DateTime.Now,
                Destination = "Somewhere else than here",
                Duration = 900
            };

            Route returnItem = null;
            returnItem = ais.CreateRoute(item);

            Assert.AreEqual<Route>(item, returnItem);
        }

        [TestMethod]
        public void AdminstrationContractGetRoute()
        {
            AdminstrationContract ais = getAdministrationContract();
            Route item = null;
            try
            {
                item = ais.GetRoute(1);
            }
            catch (RouteNotFoundException)
            {
                Assert.Fail("RouteNotFoundException");
            }
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void AdminstrationContractUpdateRoute()
        {
            AdminstrationContract ais = getAdministrationContract();
            Route item = null;
            try
            {
                item = ais.GetRoute(1);
            }
            catch (RouteNotFoundException)
            {
                Assert.Fail("RouteNotFoundException");
            }

            item.Duration++;
            Route returnItem = null;
            try
            {
                returnItem = ais.UpdateRoute(item);
            }
            catch (RouteNotFoundException)
            {
                Assert.Fail("RouteNotFoundException");
            }

            Assert.AreEqual(item.Duration, returnItem.Duration);
        }

        [TestMethod]
        public void AdminstrationContractDeleteRoute()
        {
            AdminstrationContract ais = getAdministrationContract();
            Route item = null;
            try
            {
                item = ais.GetRoute(1);
            }
            catch (RouteNotFoundException)
            {
                Assert.Fail("RouteNotFoundException");
            }

            bool result = false;
            try
            {
                result = ais.DeleteRoute(item);
            }
            catch (RouteNotFoundException)
            {
                Assert.Fail("RouteNotFoundException");
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdminstrationContractGetCustomers()
        {
            AdminstrationContract ais = getAdministrationContract();
            List<Customer> itemList = ais.GetAllCustomer();
            Assert.AreNotEqual(0, itemList.Count);
        }

        [TestMethod]
        public void AdminstrationContractGetFerries()
        {
            AdminstrationContract ais = getAdministrationContract();
            List<Ferry> itemList = ais.GetAllFerries();
            Assert.AreNotEqual(0, itemList.Count);
        }

        public void AdminstrationContractGetTrips()
        {
            AdminstrationContract ais = getAdministrationContract();
            List<Trip> itemList = ais.GetAllTrips();
            Assert.AreNotEqual(0, itemList.Count);
        }

        [TestMethod]
        public void AdminstrationContractGetReservations()
        {
            AdminstrationContract ais = getAdministrationContract();
            List<Reservation> itemList = ais.GetAllReservations();
            Assert.AreNotEqual(0, itemList.Count);
        }

        public void AdminstrationContractGetVehicles()
        {
            AdminstrationContract ais = getAdministrationContract();
            List<Vehicle> itemList = ais.GetAllVehicles();
            Assert.AreNotEqual(0, itemList.Count);
        }

        [TestMethod]
        public void AdminstrationContractGetRoutes()
        {
            AdminstrationContract ais = getAdministrationContract();
            List<Route> itemList = ais.GetAllRoutes();
            Assert.AreNotEqual(0, itemList.Count);
        }
        #endregion
    }
}