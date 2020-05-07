
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class AdministratorService
    {
        public IAdministratorRepository administratorRepository;
        public ICustomerRepository customerRepository;
    private string administratorId;

    public AdministratorService(IAdministratorRepository administratorRepository, ICustomerRepository customerRepository)
        {
            this.administratorRepository = administratorRepository;
            this.customerRepository = customerRepository;
        }

    /*public object GetAdministratorByAdministratorId(object administratorId)
    {
        throw new NotImplementedException();
    }

    public object GetAdministratorByAdministratorId1()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetAdministratorCustomers(object administratorId)
    {
        throw new NotImplementedException();
    }

    public object AdministratorByAdministratorId => throw new NotImplementedException();

    public object GetAdministratorByAdministratorId()
    {
        throw new NotImplementedException();
    }
    */
    public Administrator GetAdministratorByAdministratorId(string administratorId)
        {
            Guid administratorIdGuid = Guid.Empty;
            if (!Guid.TryParse(administratorId, out administratorIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var administrator = administratorRepository.GetAdministratorByAdministratorId(administratorIdGuid);
            if (administrator == null)
            {
                throw new EntityNotFoundException(administratorIdGuid);
            }

            return administrator ;
        }

    public void AddCustomer(object customerId, object userId, string userName, string password)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetAdministratorCustomers(string administratorId)
        {
            Guid administratorIdGuid = Guid.Empty;
            if (!Guid.TryParse(administratorId, out administratorIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return customerRepository.GetAll()
                            .Where(customer => customer.Administrator != null && customer.Administrator.AdministratorId == administratorIdGuid)
                            .AsEnumerable();
        }



    public void AddCustomer(Guid CustomerId, Guid UserId, string UserName, string Password)
        {
            Guid administratorIdGuid = Guid.Empty;
            if (!Guid.TryParse(administratorId, out administratorIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var administrator = administratorRepository.GetAdministratorByAdministratorId(administratorIdGuid);
            if (administrator == null)
            {
                throw new EntityNotFoundException(administratorIdGuid);
            }
            customerRepository.Add(new Customer() { CustomerId = Guid.NewGuid(), UserId = Guid.NewGuid(), UserName = UserName, Password = Password });
        }
    }
