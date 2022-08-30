using Customer.BusinessLayer.Interfaces;
using Customer.BusinessLayer.Services;
using Customer.BusinessLayer.Services.Repository;
using Customer.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Customer.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ICustomerServices _customerServices;

        public readonly Mock<ICustomerRepository> customerservice = new Mock<ICustomerRepository>();
        private readonly User _user;
        private readonly Quote _quote;
        private readonly Policy _policy;
        private static string type = "Exception";


        public ExceptionalTests(ITestOutputHelper output)
        {
            _customerServices = new CustomerServices(customerservice.Object);

            _output = output;

            _user = new User()
            {
                UserId = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Mobile = "9908765433",
                Password = "12345678",
                Email = "abc@gmail.com",
                DOB = new DateTime(1985, 2, 3),
                IsRetired = true,
                IsValid = true,
                SocialSecurityNumber = 987654321,
                UserType = "Admin"
            };
        }

        [Fact]
        public async Task<bool> Testfor_UserNotFound()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                customerservice.Setup(repos => repos.SearchUser(_user.UserId));
                var result = await _customerServices.SearchUser(_user.UserId);
                //Assertion
                if (result == null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}

