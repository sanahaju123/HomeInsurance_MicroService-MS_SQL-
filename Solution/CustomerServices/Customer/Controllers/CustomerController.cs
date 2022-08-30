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
            var userExists = await _customerService.SearchUser(user.UserId);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            var result = await _customerService.SignUp(user);
            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            return Ok(new Response { Status = "Success", Message = "Customer created successfully!" });
        }

        [HttpGet]
        [Route("customer/retrieve-quote/{userId}")]
        public async Task<IActionResult> RetrieveQuote(int userId)
        {
            var quote = await _customerService.RetrieveQuote(userId);
            if (quote == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Quote With userId = {userId} cannot be found" });
            }
            else
            {
                return Ok(quote);
            }
        }

        [HttpGet]
        [Route("customer/view-policy/{policyKey}")]
        public async Task<IActionResult> ViewPolicy(string policyKey)
        {
            var policy = await _customerService.ViewPolicy(policyKey);
            if (policy == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Policy With key = {policyKey} cannot be found" });
            }
            else
            {
                return Ok(policy);
            }
        }

        [HttpPost]
        [Route("customer/BuyPolicy/{quoteId}")]
        public async Task<IActionResult> BuyPolicy(int quoteId, [FromBody] PolicyModel policyModel)
        {
            var result = await _customerService.BuyPolicy(quoteId, policyModel);
            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Policy creation failed! Please check user details and try again." });

            return Ok(new Response { Status = "Success", Message = "success!" });
        }
    }
}
