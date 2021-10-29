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
    [Route("api/sellerphotos/")]
    [ApiController]
    public class SellerPhotoController: ControllerBase
    {
        private ApplicationDbContext _context;
        public SellerPhotoController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get all photos
        [HttpGet("all/")]
        public IActionResult GetAllPhotos()
        {
            var sellerPhotos = _context.SellerPhotos;
            return Ok(sellerPhotos);
        }

        //Get photos for car
        [HttpGet("{carId}")]
        public IActionResult GetUserConnection(int carId)
        {
            var photos = _context.SellerPhotos.Where(c => c.CarId == carId).ToList();
            return Ok(photos);
        }

        //POST Photo
        [HttpPost]
        public IActionResult Post([FromBody] SellerPhoto sellerPhoto)
        {
            _context.SellerPhotos.Add(sellerPhoto);
            _context.SaveChanges();
            return StatusCode(201, sellerPhoto);
        }

        [HttpDelete("{photoId}/{carId}")]
        public IActionResult DeleteConnection(int photoId, int carId)
        {
            var photoToDelete = _context.SellerPhotos.Where(ptd => ptd.CarId == carId && ptd.Id == photoId).SingleOrDefault();
            _context.Remove(photoToDelete);
            _context.SaveChanges();
            return Ok(photoToDelete);
        }
    }
}
