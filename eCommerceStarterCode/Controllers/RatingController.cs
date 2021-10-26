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

    [Route("api/rating/")]
    [ApiController]
    public class RatingController: ControllerBase
    {
        private ApplicationDbContext _context;
        public RatingController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get all ratings
        [HttpGet("all"),Authorize]
        public IActionResult GetAllRatings()
        {
            var ratings = _context.Ratings;
            return Ok(ratings);
        }

        //Get ratings for car
        [HttpGet("{carId}"), Authorize]
        public IActionResult GetCarRatings([FromBody]int carId)
        {
            var ratings = _context.Ratings.Where(r => r.CarId == carId);
            return Ok(ratings);
        }

        //POST Rating
        [HttpPost]
        public IActionResult Post([FromBody]Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
            return StatusCode(201, rating);
        }

    }
}
