using System;
using System.Collections.Generic;
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

        public Flight flight { get; set; }
    }   
}
