using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;

namespace FlyArcARS.ApplicationLogic.Services
{
    public class CustomerService
    {
        public ICustomerRepository customerRepository;
        public IPassengerRepository passengerRepository;
        private Guid userIdGuid;
        private Passenger passenger;

        public CustomerService(ICustomerRepository customerRepository, IPassengerRepository passengerRepository)
        {
            this.customerRepository = customerRepository;
            this.passengerRepository = passengerRepository;
        }

        public Customer GetCustomerByUserId(string userId)
        {
            Guid customerIdGuid = Guid.Empty;
            if(!Guid.TryParse(userId, out userIdGuid))
            {

                throw new Exception("Invalid Guid Format");
            }

            var customer = customerRepository.GetCustomerByUserId(userIdGuid);
            if(customer == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return customer;
        }

        public IEnumerable<Passenger> GetCustomerPassengers(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if(!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return passengerRepository.GetAll()
                                .Where(Passenger => Passenger.customer != null && passenger.customer.UserId == userIdGuid)
                                .AsEnumerable();
        }

        public void AddPassenger(string userId, string firstName, string lastName, string address, string city, string country, int age)
        {
            throw new NotImplementedException();
        }

        public void AddPassenger(string userId, string firstName, string lastName, string address, string city, string country, string age)
        {
            throw new NotImplementedException();
        }

        public void AddPassenger(string userId, string passFirstName, string passLastName, string passMail, string passAddress, string passCity, string passCountry, int passAge)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var customer = customerRepository.GetCustomerByUserId(userIdGuid);
            if(customer == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }
            passengerRepository.Add(new Passenger() { PassengerId = Guid.NewGuid(), FirstName = passFirstName, LastName = passLastName, Address = passAddress, Age = passAge, City = passCity, Country = passCountry, Mail = passMail });
        }
    }
}
