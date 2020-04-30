﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArc - Airline Reservation System.Models.Administrator
{
    public class AdministratorCustomersViewModel
{
        public Administrator Administrator { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
}
}
