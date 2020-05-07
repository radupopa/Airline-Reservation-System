using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Data;


    public class AdministratorCustomersViewModel
{
        public Administrator Administrator { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
}

