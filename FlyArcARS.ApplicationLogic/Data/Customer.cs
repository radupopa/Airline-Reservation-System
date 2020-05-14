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
        public Administrator Administrator { get; set; }

        public IReadOnlyCollection<Passenger> GetPassengerWithAgeGreaterThan(int age)
        {
            var passengersList = new List<Passenger>();
            foreach (var passenger in Passengers)
            {
                var age1 = passenger.Age;
                //.Where(t => t.TicketId == ticket.TicketId);
                if (age1 > age)
                {
                    passengersList.Add(passenger);
                }
            }
            return passengersList.AsReadOnly();
        }

        public IReadOnlyCollection<Passenger> GetPassengerWithAgeSmallerThan(int age)
        {
            var passengersList = new List<Passenger>();
            foreach (var passenger in Passengers)
            {
                var age1 = passenger.Age;
                //.Where(t => t.TicketId == ticket.TicketId);
                if (age1 < age)
                {
                    passengersList.Add(passenger);
                }
            }
            return passengersList.AsReadOnly();
        }

        public void Add(Passenger passenger)
        {
            throw new NotImplementedException();
        }
    }
}
