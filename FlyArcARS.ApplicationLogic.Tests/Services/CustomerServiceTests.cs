using FlyArcARS.ApplicationLogic.Abstractions;
using FlyArcARS.ApplicationLogic.Data;
using FlyArcARS.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArcARS.ApplicationLogic.Tests.Services
{
    [TestClass]
    public class CustomerServiceTests
    {
        private Mock<ICustomerRepository> customerRepoMock = new Mock<ICustomerRepository>();
        private Mock<IPassengerRepository> passengerRepoMock = new Mock<IPassengerRepository>();
        private Mock<IAdministratorRepository> administratorRepoMock = new Mock<IAdministratorRepository>();
        private Guid existingUserId = Guid.Parse("7299FFCC-435E-4A6D-99DF-57A4D6FBA712");


        [TestInitialize]
        public void InitializeTest()
        {


            var customer = new Customer
            {
                CustomerId = existingUserId,
                UserId = Guid.Parse("7299FFCC-435E-4A6D-99DF-57A4D6FBA712"),
                UserName = "Flight",
                Password = "Source"
            };

            customerRepoMock.Setup(customerRepo => customerRepo.GetCustomerByUserId(existingUserId))
                            .Returns(customer);

        }

        [TestMethod]
        public void GetCustomerByUserId_ThrowsException_WhenCustomerIdHasInvalidValue()
        {
            //arrange
            //ICustomerRepository customerRepository, IPassengerRepository, IAdministratorRepository
            var customerService = new CustomerService(customerRepoMock.Object, passengerRepoMock.Object, administratorRepoMock.Object);

            var badUserId = "jkajsdkasj dkj daksdj as";
            //act            
            //assert
            Assert.ThrowsException<Exception>(() => {
                customerService.GetCustomerByUserId(badUserId);
            });
        }

            [TestMethod]
            public void GetCustomerByUserId_Returns_UserWhenExists()
            {

                Exception throwException = null;
                var customerService = new CustomerService(customerRepoMock.Object, passengerRepoMock.Object, administratorRepoMock.Object);
                Customer user = null;
                //act   
                try
                {
                    user = customerService.GetCustomerByUserId(existingUserId.ToString());
                }
                catch (Exception e)
                {
                    throwException = e;
                }
                //assert
                Assert.IsNull(throwException, $"Exception was thrown");
                Assert.IsNotNull(user);
            }
    }
}
