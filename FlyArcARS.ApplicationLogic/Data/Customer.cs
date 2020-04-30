using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Data
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Passenger> Passengers { get; set; }
    }
}
