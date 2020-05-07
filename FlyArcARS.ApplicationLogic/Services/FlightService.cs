using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.ApplicationLogic.Services
{
    public class FlightService
    {
        private IFlightRepository flightRepository;
        private ITicketRepository ticketRepository;
        private Guid ticketIdGuid;
        private string ticketId;

        public FlightService(IFlightRepository flightRepository, ITicketRepository ticketRepository)
        {
            this.flightRepository = flightRepository;
            this.ticketRepository = ticketRepository;
        }

        public Flight GetFlightByFlightId(string flightId)
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

       

        public Flight GetFlightByFlightName(string Name)
        {
            var flight = flightRepository.GetFlightByName(Name);

            return flight;

        }

      //  public object GetFlightByFlightId(object flightId)
     //   {
       //     throw new NotImplementedException();
//}

        public IEnumerable<Ticket> GetFlightsTickets (string flightId)
        {
            Guid flightIdGuid = Guid.Empty;
            if (!Guid.TryParse(flightId, out flightIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return ticketRepository.GetAll()
                .Where(ticket => ticket.flight != null && ticket.TicketId == ticketIdGuid)
                .AsEnumerable();

        }


        public void AddTicket ( Flight Id, string FirstName, string LastName, string ticketType)
        {
            Guid ticketIdGuid = Guid.Empty;
            if (!Guid.TryParse(ticketId, out ticketIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var flight = flightRepository.GetFlightByFlightId(ticketIdGuid);
            if ( flight == null )
            {
                throw new EntityNotFoundException(ticketIdGuid);
            }
            flightRepository.Add(new Ticket() { TicketId = Guid.NewGuid(), PassengerFirstName = FirstName, PassengerLastName = LastName, Type = ticketType });

        }
    }
}
