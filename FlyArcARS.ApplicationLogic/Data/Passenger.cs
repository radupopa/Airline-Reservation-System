using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Data
{
    public class Passenger
    {
        public Guid PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public Customer customer { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
