using Customer.BusinessLayer.Interfaces;
using Customer.BusinessLayer.ViewModels;
using Customer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerService;

        public CustomerController(ICustomerServices customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        [Route("customer/signup")]
        public async Task<IActionResult> SignUp([FromBody] User user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("customer/retrieve-quote/{userId}")]
        public async Task<IActionResult> RetrieveQuote(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("customer/view-policy/{policyKey}")]
        public async Task<IActionResult> ViewPolicy(string policyKey)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("customer/BuyPolicy/{quoteId}")]
        public async Task<IActionResult> BuyPolicy(int quoteId, [FromBody] PolicyModel policyModel)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
