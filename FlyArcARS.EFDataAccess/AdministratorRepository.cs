using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.EFDataAccess
{
    public class AdministratorRepository : BaseRepository<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(FlyArcDbContext dbContext) : base(dbContext)
        {
        }

        public Administrator Add(Administrator itemToAdd)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Administrator itemToDelete)
        {
            throw new NotImplementedException();
        }

        public Administrator GetAdministratorByAdministratorId(Guid administratorIdGuid)
        {
            throw new NotImplementedException();
        }

        public Administrator Update(Administrator itemToUpdate)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrator> IRepository<Administrator>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
