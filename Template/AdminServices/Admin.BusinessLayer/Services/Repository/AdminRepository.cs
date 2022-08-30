using Admin.DataLayer;
using Admin.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BusinessLayer.Services.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AdminDbContext _dbContext;

        public AdminRepository(AdminDbContext dbContext)
        {
            _dbContext = dbContext;
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