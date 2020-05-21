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
    public class AdministratorServiceTests
    {
        private Mock<IAdministratorRepository> administratorRepoMock = new Mock<IAdministratorRepository>();
        private Mock<ICustomerRepository> customerRepoMock = new Mock<ICustomerRepository>();
        private Guid existingUserId = Guid.Parse("7299ffcc-435e-4a6d-99df-57a4d6fba123");


        [TestInitialize]
        public void InitializeTest()
        {


            var administrator = new Administrator
            {
                AdministratorId = existingUserId,
                FullName = "Name",
                UserName = "User",
                Password = "Password"
            };

            administratorRepoMock.Setup(administratorRepo => administratorRepo.GetAdministratorByAdministratorId(existingUserId))
                            .Returns(administrator);

        }


        [TestMethod]
        public void GetAdministratorByAdministratorId_ThrowsEntityNotFound_WhenUserDoesNotExist()
        {
            //arrange
            var nonExistingUserId = "7299FFCC-435E-4A6D-99DF-57A4D6FBA747";
            var administratorService = new AdministratorService(administratorRepoMock.Object, customerRepoMock.Object);

            //act            
            //assert
            Assert.ThrowsException<EntityNotFoundException>(() => {
                administratorService.GetAdministratorByAdministratorId(nonExistingUserId);
            });
        }
        
                [TestMethod]
                public void GetAdministratorByAdministratorId_Returns_UserWhenExists()
                {

                    Exception throwException = null;
                    var administratorService = new AdministratorService(administratorRepoMock.Object, customerRepoMock.Object);
                    Administrator user = null;
                    //act   
                    try
                    {
                        user = administratorService.GetAdministratorByAdministratorId(existingUserId.ToString());
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





