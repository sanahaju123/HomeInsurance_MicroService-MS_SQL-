using Customer.BusinessLayer.ViewModels;
using Customer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessLayer.Services.Repository
{
    public interface ICustomerRepository
    {
        Task<User> SignUp(User user);
        Task<User> SearchUser(int userId);
        Task<Policy> ViewPolicy(string policyKey);
        Task<Policy> BuyPolicy(int QuoteId, PolicyModel policyModel);
        Task<Quote> RetrieveQuote(int userid);
    }
}
