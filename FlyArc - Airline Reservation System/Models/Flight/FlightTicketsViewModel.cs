using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArc - Airline Reservation System.Models.Flight
{
    public class FlightTicketsViewModel
{
        public Flight Flight { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
}
}
