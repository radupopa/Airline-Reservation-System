using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Data;


    public class FlightTicketsViewModel
{
        public Flight Flight { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
}

