using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.ApplicationLogic.Abstractions
{
    public interface ICustomerRepository: IRepository<Customer>
    {
        Customer GetCustomerByUserId(Guid userId);
    }
}
