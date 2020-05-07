using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.ApplicationLogic.Abstractions
{
    public interface IFlightRepository: IRepository<Flight>
    {
        Flight GetFlightByFlightId(Guid ticketId);
        Flight GetFlightByName(string name);
        void Add(Ticket ticket);
    }
}
