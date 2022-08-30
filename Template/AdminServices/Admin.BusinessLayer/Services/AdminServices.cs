using Admin.BusinessLayer.Interfaces;
using Admin.BusinessLayer.Services.Repository;
using Admin.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IAdminRepository _adminRepository;

        public AdminServices(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<Quote> AddQuote(Quote quote)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Policy> CancelPolicy(string PolicyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Policy> RenewPolicy(string policyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Quote> RetrieveQuote(int userid)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<User> SearchUser(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<User> SignUp(User user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Policy> ViewPolicy(string policyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
