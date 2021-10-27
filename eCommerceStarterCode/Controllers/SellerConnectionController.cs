using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
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
    [Route("api/seller/")]
    [ApiController]
    public class SellerConnectionController : ControllerBase
    {
        private ApplicationDbContext _context;
        public SellerConnectionController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get all ratings
        [HttpGet("all/")]
        public IActionResult GetAllCarts()
        {
            var shoppingCarts = _context.ShoppingCarts;
            return Ok(shoppingCarts);
        }

        //Get ratings for car
        [HttpGet("{userId}")]
        public IActionResult GetUserConnection(string userId)
        {
            var connections = _context.SellerConnections.Where(r => r.UserId == userId).ToList();
            return Ok(connections);
        }

        //POST Rating
        [HttpPost]
        public IActionResult Post([FromBody] SellerConnection sellerConnection)
        {
            _context.SellerConnections.Add(sellerConnection);
            _context.SaveChanges();
            return StatusCode(201, sellerConnection);
        }

        [HttpDelete("{userId}/{carId}")]
        public IActionResult DeleteConnection(string userId, int carId)
        {
            var connectionToDelete = _context.SellerConnections.Where(ctd => ctd.UserId == userId && ctd.CarId == carId).SingleOrDefault();
            _context.Remove(connectionToDelete);
            _context.SaveChanges();
            return Ok(connectionToDelete);
        }
    }
}
