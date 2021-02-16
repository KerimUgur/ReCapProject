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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbycustomerid")]

        public IActionResult GetByCustomerId(int id)
        {
            var result = _customerService.GetByCustomerId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Customers customers)
        {
            var result = _customerService.Add(customers);
            if (result.Success)
            {
                return Ok(customers);
            }
            return BadRequest(customers);
        }

        [HttpPost("delete")]

        public IActionResult Delete(Customers customers)
        {
            var result = _customerService.Delete(customers);
            if (result.Success)
            {
                return Ok(customers);
            }
            return BadRequest(customers);
        }

    }
}
