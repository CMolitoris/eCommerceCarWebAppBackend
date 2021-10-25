using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eCommerceStarterCode.Models;



namespace eCommerceStarterCode.Controllers
{
    [Route("api/order")]
    [ApiController]

    public class OrderController : ControllerBase
    {
        private ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/order
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            // Retrieve all movies from db logic
            var orders = _context.Orders;
            return Ok(orders);
        }

        [HttpGet, Authorize]
        public IActionResult GetIdOrders([FromBody]string userId)
        {
            var custOrders = _context.Orders.Where(co => co.UserId == userId).ToList();
            return Ok(custOrders);
        }
        
        [HttpGet, Authorize]
        public IActionResult makeOrder([FromBody]Order value)
        {
            _context.Orders.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

    }
}
