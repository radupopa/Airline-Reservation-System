using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.ApplicationLogic.Abstractions
{
    public interface IPassengerRepository : IRepository<Passenger>
    {
        Passenger GetPassengerByPassengerId(Guid PassengerId);
    }
}
