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
    [Route("api/car/")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/car/
        [HttpGet]
        public IActionResult GetAllCars()
        {
            var cars = _context.Cars;
            return Ok(cars);
        }

        // POST api/car/
        [HttpPost]
        public IActionResult PostCar([FromBody]Car newCar)
        {
            _context.Cars.Add(newCar);
            _context.SaveChanges();
            return StatusCode(201, newCar);
        }

        [HttpGet("all-models")]
        public IActionResult GetCarModels()
        {
            var models = _context.Cars.Select(c => c.Make).Distinct().ToList();

            return Ok(models);
        }

        // GET api/car/{carId}
        [HttpGet("{carId}")]
        public IActionResult GetIdOrders(int carId)
        {
            var selectedCar = _context.Cars.Where(c => c.Id == carId).ToList();
            return Ok(selectedCar);
        }

        [HttpGet("cars/last")]
        public IActionResult GetLastCar()
        {
            var lastCar = _context.Cars.OrderBy(lc => lc.Id).Select(lc => lc.Id).LastOrDefault();
            return Ok(lastCar);
        }

        // PUT api/car/edit/{carId}
        [HttpPut("edit/{carId}")]
        public IActionResult UpdateCar(int carId, [FromBody] Car value)
        {
            var car = _context.Cars.Where(o => o.Id == carId).SingleOrDefault();
            if (car == null)
            {
                return NotFound("Requested order not found");
            }
            car.Price = value.Price;
            car.Make = value.Make;
            car.Model = value.Model;
            car.Year = value.Year;
            car.Type = value.Type;
            car.Description = value.Description;
            car.Mileage = value.Mileage;
           

            _context.Cars.Update(car);
            _context.SaveChanges();
            return StatusCode(201, car);
        }

        // DELETE api/car/delete/{carID}
        [HttpDelete("delete/{carId}")]
        public IActionResult DeleteCar(int carId)
        {   
            Car car = _context.Cars.Where(c => c.Id == carId).SingleOrDefault();
            _context.Cars.Remove(car);
            _context.SaveChanges();
            return Ok(car);
        }

    }
}
