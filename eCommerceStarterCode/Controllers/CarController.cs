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
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            var cars = _context.Cars;
            return Ok(cars);
        }
        [HttpPost]
        public IActionResult PostCar([FromBody]Car newCar)
        {
            _context.Cars.Add(newCar);
            _context.SaveChanges();
            return StatusCode(201, newCar);
        }

    }
}
