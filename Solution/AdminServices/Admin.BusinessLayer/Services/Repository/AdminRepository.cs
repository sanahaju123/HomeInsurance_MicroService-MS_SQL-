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
            try
            {
                var result = await _dbContext.Quotes.AddAsync(quote);
                await _dbContext.SaveChangesAsync();
                return quote;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Policy> CancelPolicy(string PolicyKey)
        {
            var policy = await _dbContext.Policies.FindAsync(PolicyKey);
            try
            {
                policy.PolicyStatus = "CANCELLED";
                policy.PolicyTerm = 0;

                _dbContext.Policies.Update(policy);
                await _dbContext.SaveChangesAsync();
                return policy;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Policy> RenewPolicy(string policyKey)
        {
            var policy = await _dbContext.Policies.FindAsync(policyKey);
            try
            {
                policy.PolicyStatus = "RENEWED";
                policy.PolicyTerm = 2;

                _dbContext.Policies.Update(policy);
                await _dbContext.SaveChangesAsync();
                return policy;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Quote> RetrieveQuote(int userid)
        {
            try
            {
                return await _dbContext.Quotes.FindAsync(userid);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<User> SearchUser(int userId)
        {
            try
            {
                return await _dbContext.Users.FindAsync(userId);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<User> SignUp(User user)
        {
            try
            {
                var result = await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Policy> ViewPolicy(string policyKey)
        {
            try
            {
                return await _dbContext.Policies.FindAsync(policyKey);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}