using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;
using FlyArcARS.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Tests.Services
{
    [TestClass]
    public class FlightServiceTests
    {
        private Mock<IFlightRepository> flightRepoMock = new Mock<IFlightRepository>();
        private Mock<ITicketRepository> ticketRepoMock = new Mock<ITicketRepository>();
        private Guid existingUserId = Guid.Parse("7299FFCC-435E-4A6D-99DF-57A4D6FBA712");


        [TestInitialize]
        public void InitializeTest()
        {


            var flight = new Flight
            {
                FlightId = existingUserId,
                NumberOfSeats = 250,
                Name = "Flight",
                Source = "Source",
                Destination = "Destination",
                Time = 99,
                Price = 120
            };

            flightRepoMock.Setup(flightRepo => flightRepo.GetFlightByFlightId(existingUserId))
                            .Returns(flight);

        }

        [TestMethod]
        public void GetFlightByFlightId_ThrowsException_WhenFlightIdHasInvalidValue()
        {
            //arrange
            //IFlightRepository flightRepository, IFlightRepository
            var flightService = new FlightService(flightRepoMock.Object, ticketRepoMock.Object);

            var badUserId = "jkajsdkasj dkj daksdj as";
            //act            
            //assert
            Assert.ThrowsException<Exception>(() => {
                flightService.GetFlightByFlightId(badUserId);
            });
        }

        [TestMethod]
        public void GetFlightByFlightId_ThrowsEntityNotFound_WhenUserDoesNotExist()
        {
            //arrange
            var nonExistingUserId = "7299FFCC-435E-4A6D-99DF-57A4D6FBA747";
            var flightService = new FlightService(flightRepoMock.Object, ticketRepoMock.Object) ;

            //act            
            //assert
            Assert.ThrowsException<EntityNotFoundException>(() => {
               flightService.GetFlightByFlightId(nonExistingUserId);
            });
        }
    }
}
