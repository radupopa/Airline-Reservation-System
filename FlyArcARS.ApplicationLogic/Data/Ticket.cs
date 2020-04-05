using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Data
{
    public class Ticket
    {
        public Guid TicketId { get; set; }
        public double Price { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Type { get; set; }
    }   
}
