using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Data
{
    public class Flight
    {
        public Guid FlightId { get; set; }
        public int NumberOfSeats { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Time { get; set; }
        public int Price { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public static implicit operator Flight(Customer v)
        {
            throw new NotImplementedException();
        }


        public Flight()
        {
            Tickets = new List<Ticket>();
        }

        public Flight GetWithPriceGreaterThan(int v)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Ticket> GetFlightsWithPriceGreaterThan(int price)
        {
            var ticketsList = new List<Ticket>();
            foreach (var ticket in Tickets)
            {
                var price1 = ticket.Price;
                               //.Where(t => t.TicketId == ticket.TicketId);
                if (price1 > price)
                {
                    ticketsList.Add(ticket);
                }
            }
            return ticketsList.AsReadOnly();
        }

        public IReadOnlyCollection<Ticket> GetFlightsWithPriceSmallerThan(int price)
        {
            var ticketsList = new List<Ticket>();
            foreach (var ticket in Tickets)
            {
                var price1 = ticket.Price;
                //.Where(t => t.TicketId == ticket.TicketId);
                if (price1 < price)
                {
                    ticketsList.Add(ticket);
                }
            }
            return ticketsList.AsReadOnly();
        }

        public void Add(Flight flight)
        {
            throw new NotImplementedException();
        }

        public void Add(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Flight GetFlightsWithNumberOfSeatsGreaterThan(int noSeats)
        {
            /* var flightsList = new Flight();
             foreach (var flight in )
             {
                 var noSeats1 = NumberOfSeats;
                 //.Where(t => t.TicketId == ticket.TicketId);
                 if (noSeats1 > noSeats)
                 {
                     flightsList.Add(flight);
                 }
             }
             return flightsList.AsReadOnly();*/
            // }
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Ticket> GetFlightsOfType(string type)
        {
            var ticketsList = new List<Ticket>();
            foreach (var ticket in Tickets)
            {
                var type1 = ticket.Type;
                //.Where(t => t.Type == ticket.Type);
                if (type1 == type)
                {
                    ticketsList.Add(ticket);
                }

                ticketsList.Add(ticket);

            }
            return ticketsList.AsReadOnly();
        }

        public IReadOnlyCollection<Ticket> GetFlightsWithPassengerLastName(string ln)
        {
            var ticketsList = new List<Ticket>();
            foreach (var ticket in Tickets)
            {
                var ln1 = ticket.PassengerLastName;
                //.Where(t => t.Type == ticket.Type);
                if (ln1 == ln)
                {
                    ticketsList.Add(ticket);
                }

                ticketsList.Add(ticket);

            }
            return ticketsList.AsReadOnly();
        }
    }
    }

