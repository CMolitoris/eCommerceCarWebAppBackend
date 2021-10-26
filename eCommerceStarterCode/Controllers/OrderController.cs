using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eCommerceStarterCode.Models;



namespace eCommerceStarterCode.Controllers
{
    [Route("api/order/")]
    [ApiController]

    public class OrderController : ControllerBase
    {
        private ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/order/
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            // Retrieve all movies from db logic
            var orders = _context.Orders;
            return Ok(orders);
        }

        // GET api/order/{userId}
        [HttpGet("{userId}"), Authorize]
        public IActionResult GetIdOrders(string userId)
        {
            var custOrders = _context.Orders.Where(co => co.UserId == userId).ToList();
            return Ok(custOrders);
        }
        
        // POST api/order/new
        [HttpPost("new"), Authorize]
        public IActionResult makeOrder([FromBody]Order value)
        {
            _context.Orders.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // Put api/order/edit/{orderId}
        [HttpPut("edit/{orderId}"), Authorize]
        public IActionResult updateOrder(int orderId, [FromBody]Order value)
        {
            var order = _context.Orders.Where(o => o.Id == orderId).SingleOrDefault();
            if (order == null)
            {
                return NotFound("Requested order not found");
            }
            order.Id = value.Id;
            order.Total = value.Total;
            order.ShippingCost = value.ShippingCost;
            order.Shipped = value.Shipped;
            order.ShippingNumber = value.ShippingNumber;
            order.Delivered = value.Delivered;
            order.UserId = value.UserId;

            _context.Orders.Update(order);
            _context.SaveChanges();
            return StatusCode(201, order);
        }
    }
}
