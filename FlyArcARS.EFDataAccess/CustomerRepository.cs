using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.EFDataAccess
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(FlyArcDbContext dbContext) : base(dbContext)
        {
        }

        public Customer GetCustomerByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }


    }
}
