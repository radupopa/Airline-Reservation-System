using FlyArcARS.ApplicationLogic.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FlyArcARS.ApplicationLogic.Tests
{
    [TestClass]
    public class TicketLogicTests
    {
       /* [TestMethod]
        public void GetTicketsOfType_Returns_OnlyTicketsWithType()
        {
            //Arrange
            Ticket ticket = new Ticket()
            {
                TicketId = Guid.NewGuid(),
                PassengerFirstName = "First Name",
                PassengerLastName = "Last Name",
                Type = "Type",
                Price = 200,
                flight = new Flight

                {
                    FlightId = Guid.NewGuid(),
                    NumberOfSeats = 255,
                    Name = "Flight ",
                    Source = "Source ",
                    Destination = "Destination ",
                    Time = 200
                },
                Passenger = new Passenger

                {
                    PassengerId = Guid.NewGuid(),
                    FirstName = "Name",
                    LastName = "Last ",
                    Mail = "Mail ",
                    Address = "address ",
                    City = "city",
                    Country = "country",
                    Age = 10 
                }
            };

            var firstTicketId = Guid.NewGuid();
            var secondTicketId = Guid.NewGuid();
            var thirdTicketId = Guid.NewGuid();
            var forthTicketId = Guid.NewGuid();
            var fifthTicketId = Guid.NewGuid();

            List<Ticket> tickets1 = new List<Ticket>
                                     {
                                       new Ticket {TicketId= firstTicketId, PassengerFirstName = "Name1", PassengerLastName="Name1", Type = "Type1", Price = 99 },
                                       new Ticket {TicketId= secondTicketId, PassengerFirstName = "Name2", PassengerLastName="Name2", Type = "Type2", Price = 99 },
                                       new Ticket {TicketId= thirdTicketId, PassengerFirstName = "Name3", PassengerLastName="Name3", Type = "Type3", Price = 99 },
                                       new Ticket {TicketId= forthTicketId, PassengerFirstName = "Name4", PassengerLastName="Name4", Type = "Type4", Price = 99 },
                                       new Ticket {TicketId= fifthTicketId, PassengerFirstName = "Name5", PassengerLastName="Name5",  Type = "Type5", Price = 99 }
                                     };
            foreach (var ticket1 in tickets1)
                ticket1.flight.Add(ticket1);

            //Act
            var retList = ticket.GetOfType("Type1");

            //Assert            
            Assert.AreEqual(1, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();
            Assert.AreEqual(fifthTicketId, collectionEnum.Current.TicketId);
        }

    */

    }
}