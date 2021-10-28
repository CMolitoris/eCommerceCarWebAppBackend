using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/shoppingcart/")]
    [ApiController]
    public class ShoppingCartController: ControllerBase
    {
        private ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
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
        public IActionResult GetUserCart(string userId)
        {
            var ratings = _context.ShoppingCarts.Where(r => r.UserId==userId).ToList();
            return Ok(ratings);
        }

        //Get ratings for car
        [HttpGet("details/{userId}")]
        public IActionResult GetUserCartDetails(string userId)
        {
            var ratings = _context.ShoppingCarts
                .Where(r => r.UserId == userId)
                .Include(r => r.Car)
                .Select(r => new {r.CarId, r.Quantity, r.Car.Model, r.Car.Make, r.Car.Price, ExtendedPrice = r.Quantity * r.Car.Price})
                .ToList();
            return Ok(ratings);
        }

        //POST Rating
        [HttpPost]
        public IActionResult Post([FromBody] ShoppingCart shoppingCart)
        {
            _context.ShoppingCarts.Add(shoppingCart);
            _context.SaveChanges();
            return StatusCode(201, shoppingCart);
        }

        [HttpDelete("{userId}/{carId}")]
        public IActionResult DeleteCart(string userId,int carId)
        {
            var cartToDelete = _context.ShoppingCarts.Where(ctd => ctd.UserId == userId && ctd.CarId == carId).SingleOrDefault();
            _context.Remove(cartToDelete);
            _context.SaveChanges();
            return Ok(cartToDelete);
        }
    }
}
