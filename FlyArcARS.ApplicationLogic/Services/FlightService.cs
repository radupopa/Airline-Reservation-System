using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.ApplicationLogic.Services
{
    public class FlightService
    {
        private IFlightRepository flightRepository;
        private ITicketRepository ticketRepository;

        public FlightService(IFlightRepository flightRepository, ITicketRepository ticketRepository)
        {
            this.flightRepository = flightRepository;
            this.ticketRepository = ticketRepository;
        }

        public Customer GetFlightByFlightId(string flightId)
        {
            Guid flightIdGuid = Guid.Empty;
            if (!Guid.TryParse(flightId, out flightIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var flight = flightRepository.GetFlightByFlightId(flightIdGuid);
            if (flight == null)
            {
                throw new EntityNotFoundException(ticketIdGuid);
            }

            return flight;
          
        }

        public IEnumerable<Ticket> GetFlightsTickets (string flightId)
        {
            Guid flightIdGuid = Guid.Empty;
            if (!Guid.TryParse(flightId, out flightIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return ticketRepository.GetAll()
                .Where(ticket => ticket.Flight != null && ticket.Flight.TicketId == ticketIdGuid)
                .AsEnumerable();

        }

        public void AddTicket ( string Id, string FirstName, string LastName, string ticketType)
        {
            Guid ticketIdGuid = Guid.Empty;
            if (!Guid.TryParse(ticketId, out ticketIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var flight = flightRepository.GetFlightByFlightId(ticketIdGuid);
            if ( teacher == null )
            {
                throw new EntityNotFoundException(ticketIdGuid);
            }
            flightRepository.Add(new Ticket() { Id = Guid.NewGuid(), Flight = flight, PassengerFirstName = FirstName, PassengerLastName = LastName, ticketType = Type });

        }
    }
}
