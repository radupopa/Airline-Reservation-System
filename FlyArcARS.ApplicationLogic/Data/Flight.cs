using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Data
{
    public class Flight
    {
        public Guid FlightId { get; set; }
        public int NumberOfSeats { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Time { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
