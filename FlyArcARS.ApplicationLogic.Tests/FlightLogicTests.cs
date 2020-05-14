using FlyArcARS.ApplicationLogic.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FlyArcARS.ApplicationLogic.Tests
{
    [TestClass]
    public class FlightLogicTests
    {

        [TestMethod]
        public void GetFlightsWithPriceGreaterThan_Returns_OnlyFlightsWithPriceGT()
        {
            //Arrange
            Flight flight = new Flight()
            {
                FlightId = Guid.NewGuid(),
                NumberOfSeats = 255,
                Name = "Flight ",
                Source = "Source ",
                Destination = "Destination ",
                Time = 200,

               
            };

            var firstTicketId = Guid.NewGuid();
            var secondTicketId = Guid.NewGuid();
            var thirdTicketId = Guid.NewGuid();
            var forthTicketId = Guid.NewGuid();
            var fifthTicketId = Guid.NewGuid();

            List<Ticket> tickets = new List<Ticket>
                                     {
                                       new Ticket {TicketId= firstTicketId, PassengerFirstName = "FirstName1", PassengerLastName="LastName1", Type="Type1", Price = 99 },
                                       new Ticket {TicketId= secondTicketId, PassengerFirstName = "FirstName2", PassengerLastName="LastName2", Type="Type2", Price = 150 },
                                       new Ticket {TicketId= thirdTicketId, PassengerFirstName = "FirstName3", PassengerLastName="LastName3", Type="Type3", Price = 175 },
                                       new Ticket {TicketId= forthTicketId, PassengerFirstName = "FirstName4", PassengerLastName="LastName4", Type="Type4", Price = 199 },
                                       new Ticket {TicketId= fifthTicketId, PassengerFirstName = "FirstName5", PassengerLastName="LastName5", Type="Type5", Price = 250 }
                                     };
            foreach (var ticket in tickets)
                flight.Tickets.Add(ticket);

            //Act
            var retList = flight.GetFlightsWithPriceGreaterThan(200);

            //Assert            
            Assert.AreEqual(1, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();
            Assert.AreEqual(fifthTicketId, collectionEnum.Current.TicketId);
        }


        [TestMethod]
        public void GetFlightsWithPriceSmallerThan_Returns_OnlyFlightsWithPriceST()
        {
            //Arrange
            Flight flight = new Flight()
            {
                FlightId = Guid.NewGuid(),
                NumberOfSeats = 255,
                Name = "Flight ",
                Source = "Source ",
                Destination = "Destination ",
                Time = 200,


            };

            var firstTicketId = Guid.NewGuid();
            var secondTicketId = Guid.NewGuid();
            var thirdTicketId = Guid.NewGuid();
            var forthTicketId = Guid.NewGuid();
            var fifthTicketId = Guid.NewGuid();

            List<Ticket> tickets = new List<Ticket>
                                     {
                                       new Ticket {TicketId= firstTicketId, PassengerFirstName = "FirstName1", PassengerLastName="LastName1", Type="Type1", Price = 99 },
                                       new Ticket {TicketId= secondTicketId, PassengerFirstName = "FirstName2", PassengerLastName="LastName2", Type="Type2", Price = 150 },
                                       new Ticket {TicketId= thirdTicketId, PassengerFirstName = "FirstName3", PassengerLastName="LastName3", Type="Type3", Price = 175 },
                                       new Ticket {TicketId= forthTicketId, PassengerFirstName = "FirstName4", PassengerLastName="LastName4", Type="Type4", Price = 199 },
                                       new Ticket {TicketId= fifthTicketId, PassengerFirstName = "FirstName5", PassengerLastName="LastName5", Type="Type5", Price = 250 }
                                     };
            foreach (var ticket in tickets)
                flight.Tickets.Add(ticket);

            //Act
            var retList = flight.GetFlightsWithPriceSmallerThan(200);

            //Assert            
            Assert.AreEqual(3, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();
            Assert.AreEqual(fifthTicketId, collectionEnum.Current.TicketId);
        }

        [TestMethod]
        public void GetFlightsOfType_Returns_OnlyFlightsWithPriceST()
        {
            //Arrange
            Flight flight = new Flight()
            {
                FlightId = Guid.NewGuid(),
                NumberOfSeats = 255,
                Name = "Flight ",
                Source = "Source ",
                Destination = "Destination ",
                Time = 200,


            };

            var firstTicketId = Guid.NewGuid();
            var secondTicketId = Guid.NewGuid();
            var thirdTicketId = Guid.NewGuid();
            var forthTicketId = Guid.NewGuid();
            var fifthTicketId = Guid.NewGuid();

            List<Ticket> tickets = new List<Ticket>
                                     {
                                       new Ticket {TicketId= firstTicketId, PassengerFirstName = "FirstName1", PassengerLastName="LastName1", Type="Type1", Price = 99 },
                                       new Ticket {TicketId= secondTicketId, PassengerFirstName = "FirstName2", PassengerLastName="LastName2", Type="Type2", Price = 150 },
                                       new Ticket {TicketId= thirdTicketId, PassengerFirstName = "FirstName3", PassengerLastName="LastName3", Type="Type3", Price = 175 },
                                       new Ticket {TicketId= forthTicketId, PassengerFirstName = "FirstName4", PassengerLastName="LastName4", Type="Type4", Price = 199 },
                                       new Ticket {TicketId= fifthTicketId, PassengerFirstName = "FirstName5", PassengerLastName="LastName5", Type="Type5", Price = 250 }
                                     };
            foreach (var ticket in tickets)
                flight.Tickets.Add(ticket);

            //Act
            var retList = flight.GetFlightsOfType("Type1");

            //Assert            
            Assert.AreEqual(1, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();
            Assert.AreEqual(fifthTicketId, collectionEnum.Current.TicketId);
        }

        [TestMethod]
        public void GetFlightsWithPassengerLastName_Returns_OnlyFlightsWithPassengerLN()
        {
            //Arrange
            Flight flight = new Flight()
            {
                FlightId = Guid.NewGuid(),
                NumberOfSeats = 255,
                Name = "Flight ",
                Source = "Source ",
                Destination = "Destination ",
                Time = 200,


            };

            var firstTicketId = Guid.NewGuid();
            var secondTicketId = Guid.NewGuid();
            var thirdTicketId = Guid.NewGuid();
            var forthTicketId = Guid.NewGuid();
            var fifthTicketId = Guid.NewGuid();

            List<Ticket> tickets = new List<Ticket>
                                     {
                                       new Ticket {TicketId= firstTicketId, PassengerFirstName = "FirstName1", PassengerLastName="LastName1", Type="Type1", Price = 99 },
                                       new Ticket {TicketId= secondTicketId, PassengerFirstName = "FirstName2", PassengerLastName="LastName2", Type="Type2", Price = 150 },
                                       new Ticket {TicketId= thirdTicketId, PassengerFirstName = "FirstName3", PassengerLastName="LastName3", Type="Type3", Price = 175 },
                                       new Ticket {TicketId= forthTicketId, PassengerFirstName = "FirstName4", PassengerLastName="LastName4", Type="Type4", Price = 199 },
                                       new Ticket {TicketId= fifthTicketId, PassengerFirstName = "FirstName5", PassengerLastName="LastName5", Type="Type5", Price = 250 }
                                     };
            foreach (var ticket in tickets)
                flight.Tickets.Add(ticket);

            //Act
            var retList = flight.GetFlightsWithPassengerLastName("LastName1");

            //Assert            
            Assert.AreEqual(1, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();
            Assert.AreEqual(fifthTicketId, collectionEnum.Current.TicketId);
        }



        //  [TestMethod]
        /*   public void GetFlightsWithNumberOfSeatsGreaterThan_Returns_OnlyFlightsWithNumberOfSeatsGT()
           {

              // var firstFlightId = Guid.NewGuid();
              // var secondFlightId = Guid.NewGuid();
              // var thirdFlightId = Guid.NewGuid();
               //Arrange
               Flight flight = new Flight()
               {
                   FlightId = Guid.NewGuid(),
                   NumberOfSeats = 255,
                   Name = "Flight ",
                   Source = "Source ",
                   Destination = "Destination ",
                   Time = 200,


               };

             /*  Flight flight2 = new Flight()
               {
                   FlightId = secondFlightId,
                   NumberOfSeats = 320,
                   Name = "Flight ",
                   Source = "Source ",
                   Destination = "Destination ",
                   Time = 200,


               };

               Flight flight3 = new Flight()
               {
                   FlightId = thirdFlightId,
                   NumberOfSeats = 255,
                   Name = "Flight ",
                   Source = "Source ",
                   Destination = "Destination ",
                   Time = 200,


               };*/

        /*      var firstFlightId = Guid.NewGuid();
              var secondFlightId = Guid.NewGuid();
              var thirdFlightId = Guid.NewGuid();
           //   var forthTicketId = Guid.NewGuid();
            //  var fifthTicketId = Guid.NewGuid();

              List<Flight> flights = new List<Flight>
                                       {
                                         new Flight {FlightId= firstFlightId, NumberOfSeats = 200, Name="LastName1", Source="Type1", Destination = "adasd", Time = 200, Price = 150 },
                                         new Flight {FlightId= secondFlightId, NumberOfSeats = 150, Name="LastName2", Source="Type2", Destination = "dsd", Time = 300, Price = 100},
                                         new Flight {FlightId= thirdFlightId, NumberOfSeats = 300, Name="LastName3", Source="Type3", Destination = "scsd", Time = 150, Price = 99}
                                       //  new Ticket {TicketId= forthTicketId, PassengerFirstName = "FirstName4", PassengerLastName="LastName4", Type="Type4", Price = 199 },
                                        // new Ticket {TicketId= fifthTicketId, PassengerFirstName = "FirstName5", PassengerLastName="LastName5", Type="Type5", Price = 250 }
                                       };
              foreach (var flight1 in flights)
              {
                  flight.Add(flight1);


              }

              //Act
              var retList = flight.GetFlightsWithNumberOfSeatsGreaterThan(200);

              //Assert            
              Assert.AreEqual(1, retList.Count);
              var collectionEnum = retList.GetEnumerator();
              collectionEnum.MoveNext();
              Assert.AreEqual(thirdFlightId, collectionEnum.Current.TicketId);
          }
          */




    }
}