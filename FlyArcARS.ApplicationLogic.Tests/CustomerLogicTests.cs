using FlyArcARS.ApplicationLogic.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FlyArcARS.ApplicationLogic.Tests
{
    [TestClass]
    public class CustomerLogicTests
    {
        [TestMethod]
        public void GetPassengersWithAgeGreaterThan_Returns_OnlyPassengersWithAgeGT()
        {
            //Arrange
            Customer customer = new Customer()
            {
                CustomerId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                UserName = "Customer",
                Password = "Password",
                Administrator = new Administrator

                {
                    AdministratorId = Guid.NewGuid(),
                    FullName = "Name",
                    UserName = "User ",
                    Password = "Pass "   
                }

            };

            var firstPassengerId = Guid.NewGuid();
            var secondPassengerId = Guid.NewGuid();
            var thirdPassengerId = Guid.NewGuid();
            var forthPassengerId = Guid.NewGuid();
            var fifthPassengerId = Guid.NewGuid();

            List<Passenger> passengers = new List<Passenger>
                                     {
                                       new Passenger {PassengerId= firstPassengerId, FirstName = "Name1", LastName="Name1",Mail = "Mail1", Address ="Address1", City = "City1", Country = "Country1", Age = 54},
                                       new Passenger {PassengerId= secondPassengerId, FirstName = "Name2", LastName="Name2", Mail = "Mail2", Address ="Address2", City = "City2", Country = "Country2", Age = 43 },
                                       new Passenger {PassengerId= thirdPassengerId, FirstName = "Name3", LastName="Name3", Mail = "Mail3", Address ="Address3", City = "City3", Country = "Country3", Age = 23 },
                                       new Passenger {PassengerId= forthPassengerId, FirstName = "Name4", LastName="Name4", Mail = "Mail4", Address ="Address4", City = "City4", Country = "Country4", Age = 18 },
                                       new Passenger{PassengerId= fifthPassengerId, FirstName = "Name5", LastName="Name5",  Mail = "Mail5", Address ="Address5", City = "City5", Country = "Country5", Age = 30 }
                                     };
            foreach (var passenger in passengers)
                customer.Passengers.Add(passenger);

            //Act
            var retList = customer.GetPassengerWithAgeGreaterThan(31);

            //Assert            
            Assert.AreEqual(1, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();
            Assert.AreEqual(fifthPassengerId, collectionEnum.Current.PassengerId);
        }


        [TestMethod]
        public void GetPassengersWithAgeSmallerThan_Returns_OnlyPassengersWithAgeSM()
        {
            //Arrange
            Customer customer = new Customer()
            {
                CustomerId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                UserName = "Customer",
                Password = "Password",

            };

            var firstPassengerId = Guid.NewGuid();
            var secondPassengerId = Guid.NewGuid();
            var thirdPassengerId = Guid.NewGuid();
            var forthPassengerId = Guid.NewGuid();
            var fifthPassengerId = Guid.NewGuid();

            List<Passenger> passengers = new List<Passenger>
                                     {
                                       new Passenger {PassengerId= firstPassengerId, FirstName = "Name1", LastName="Name1",Mail = "Mail1", Address ="Address1", City = "City1", Country = "Country1", Age = 54},
                                       new Passenger {PassengerId= secondPassengerId, FirstName = "Name2", LastName="Name2", Mail = "Mail2", Address ="Address2", City = "City2", Country = "Country2", Age = 43 },
                                       new Passenger {PassengerId= thirdPassengerId, FirstName = "Name3", LastName="Name3", Mail = "Mail3", Address ="Address3", City = "City3", Country = "Country3", Age = 23 },
                                       new Passenger {PassengerId= forthPassengerId, FirstName = "Name4", LastName="Name4", Mail = "Mail4", Address ="Address4", City = "City4", Country = "Country4", Age = 18 },
                                       new Passenger{PassengerId= fifthPassengerId, FirstName = "Name5", LastName="Name5",  Mail = "Mail5", Address ="Address5", City = "City5", Country = "Country5", Age = 30 }
                                     };
            foreach (var passenger in passengers)
                customer.Passengers.Add(passenger);

            //Act
            var retList = customer.GetPassengerWithAgeSmallerThan(31);

            //Assert            
            Assert.AreEqual(3, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();
            Assert.AreEqual(fifthPassengerId, collectionEnum.Current.PassengerId);
        }
        



    }
}