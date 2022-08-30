using Admin.BusinessLayer.Interfaces;
using Admin.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminServices _adminService;

        public AdminController(IAdminServices adminService)
        {
            _adminService = adminService;
        }

        [HttpPost]
        [Route("admin/signup")]
        public async Task<IActionResult> SignUp([FromBody] User user)
        {
            var userExists = await _adminService.SearchUser(user.UserId);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            var result = await _adminService.SignUp(user);
            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            return Ok(new Response { Status = "Success", Message = "Admin created successfully!" });
        }

        [HttpPost]
        [Route("admin/add-quote")]
        public async Task<IActionResult> AddQuote([FromBody] Quote quote)
        {
            var result = await _adminService.AddQuote(quote);
            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Quote creation failed! Please check quote details and try again." });

            return Ok(new Response { Status = "Success", Message = "Quote created successfully!" });
        }

        [HttpGet]
        [Route("admin/view-policy/{policyKey}")]
        public async Task<IActionResult> ViewPolicy(string policyKey)
        {
            var policy = await _adminService.ViewPolicy(policyKey);
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

        [HttpPut]
        [Route("admin/renew-policy/{policyKey}")]
        public async Task<IActionResult> RenewPolicy(string policyKey)
        {
            var policy = await _adminService.ViewPolicy(policyKey);
            if (policy == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Policy With key = {policyKey} cannot be found" });
            }
            else
            {
                var result = await _adminService.RenewPolicy(policyKey);
                return Ok(new Response { Status = "Success", Message = "Policy renewed successfully!" });
            }
        }

        [HttpPut]
        [Route("admin/cancel-policy/{policyKey}")]
        public async Task<IActionResult> CancelPolicy(string policyKey)
        {
            var policy = await _adminService.ViewPolicy(policyKey);
            if (policy == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = $"Policy With key = {policyKey} cannot be found" });
            }
            else
            {
                var result = await _adminService.CancelPolicy(policyKey);
                return Ok(new Response { Status = "Success", Message = "Policy cancelled successfully!" });
            }
        }

        [HttpGet]
        [Route("admin/retrieve-quote/{userId}")]
        public async Task<IActionResult> RetrieveQuote(int userId)
        {
            var quote = await _adminService.RetrieveQuote(userId);
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

    }
}
