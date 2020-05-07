using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.EFDataAccess
{
    public class FlightRepository : BaseRepository<Flight>, IFlightRepository
    {
        public FlightRepository(FlyArcDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Flight GetFlightByFlightId(Guid ticketId)
        {
            throw new NotImplementedException();
        }

        public Flight GetFlightByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
