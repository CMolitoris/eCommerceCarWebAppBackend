using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Left out Authorize
        [HttpGet("user")]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users;
            return Ok(users);
        }

        //Get current user
        [HttpGet, Authorize]
        public IActionResult GetCurrentUser()
        {
            var username = User.FindFirstValue(ClaimTypes.Name);
            var currentUser = _context.Users.Where(u => u.UserName == username).SingleOrDefault();
            return Ok(username); 
        }
    }
}
