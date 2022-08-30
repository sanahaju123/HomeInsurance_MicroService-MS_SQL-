using Admin.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BusinessLayer.Services.Repository
{
    public interface IAdminRepository
    {
        Task<User> SignUp(User user);
        Task<User> SearchUser(int userId);
        Task<Policy> ViewPolicy(string policyKey);
        Task<Policy> RenewPolicy(string policyKey);
        Task<Policy> CancelPolicy(string PolicyKey);
        Task<Quote> AddQuote(Quote quote);
        Task<Quote> RetrieveQuote(int userid);
    }
}
