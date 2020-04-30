using CourseManager.ApplicationLogic.Abstractions;
using CourseManager.ApplicationLogic.DataModel;
using CourseManager.ApplicationLogic.Exceptions;
using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerManager.ApplicationLogic.Services
{
    public class AdminService
    {
        private IAdministratorRepository administratorRepository;
        private ICustomerRepository customerRepository;

        public AdministratorService(IAdministratorRepository administratorRepository, ICustomerRepository customerRepository)
        {
            this.administratorRepository = administratorRepository;
            this.customerRepository = customerRepository;
        }

        public Administrator GetTeacherByUserId(string administratorId)
        {
            Guid administratorIdGuid = Guid.Empty;
            if (!Guid.TryParse(administratorId, out administratorIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var administrator = Repository.GetAdministratorByAdministratorId(administratorIdGuid);
            if (administrator == null)
            {
                throw new EntityNotFoundException(administratorIdGuid);
            }

            return administrator ;
        }

        public IEnumerable<Customer> GetadministratorCustomers(string administratorId)
        {
            Guid administratorIdGuid = Guid.Empty;
            if (!Guid.TryParse(administratorId, out administratorIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return customerRepository.GetAll()
                            .Where(customer => customer.Teacher != null && customer.Administrator.AdministratorId == administratorIdGuid)
                            .AsEnumerable();
        }

        public void AddCourse(string administratorId, string customerName, string customerDescription)
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
            customerRepository.Add(new Customer() { Id = Guid.NewGuid(), Administrator = administrator, Name = customerName, Description = customerDescription });
        }
    }
}