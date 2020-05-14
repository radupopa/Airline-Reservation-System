using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Data
{
    public class Ticket
    {
     //   internal object Flight;

        public Guid TicketId { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public Flight flight { get; set; }
        public Passenger Passenger { get; set; }

       /* public IReadOnlyCollection<Ticket> GetOfType(string Type)
        {
            var ticketsList = new List<Ticket>();
            foreach (var ticket in flight.Tickets)
            {
                var type = ticketsList
                .Where(t => t.Type == ticket.Type);
                
                    ticketsList.Add(ticket);
                
            }
            return ticketsList.AsReadOnly();
        }
        */

    }   
}
