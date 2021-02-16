using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("add")]

        public IActionResult Add(Rentals rentals)
        {
            var result = _rentalService.Add(rentals);
            if (result.Success)
            {
                return Ok(rentals);
            }
            return BadRequest(rentals);
        }

        [HttpGet("getcardetails")]

        public IActionResult GetRentDetails(Rentals rentals)
        {
            var result = _rentalService.GetRentDetail(rentals);
            if (result.Success)
            {
                return Ok(rentals);
            }
            return BadRequest(rentals);
        }
    }
}
