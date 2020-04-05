using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Data
{
    public class Administrator
    {
        public Guid AdministratorId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
