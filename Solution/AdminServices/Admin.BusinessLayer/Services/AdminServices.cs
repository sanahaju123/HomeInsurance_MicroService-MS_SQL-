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
            return await _adminRepository.AddQuote(quote);
        }

        public async Task<Policy> CancelPolicy(string PolicyKey)
        {
            return await _adminRepository.CancelPolicy(PolicyKey);
        }

        public async Task<Policy> RenewPolicy(string policyKey)
        {
            return await _adminRepository.RenewPolicy(policyKey);
        }

        public async Task<Quote> RetrieveQuote(int userid)
        {
            return await _adminRepository.RetrieveQuote(userid);
        }

        public async Task<User> SearchUser(int userId)
        {
            return await _adminRepository.SearchUser(userId);
        }

        public async Task<User> SignUp(User user)
        {
            return await _adminRepository.SignUp(user);
        }

        public async Task<Policy> ViewPolicy(string policyKey)
        {
            return await _adminRepository.ViewPolicy(policyKey);
        }
    }
}
