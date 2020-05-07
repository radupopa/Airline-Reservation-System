using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.ApplicationLogic.Abstractions
{
    public interface IAdministratorRepository : IRepository<Administrator>
    {
        Administrator GetAdministratorByAdministratorId(Guid administratorIdGuid);
    }
}
