using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryOfVehicle.Business.Abstract;
using RepositoryOfVehicle.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        IBusService _busService;

        public BusesController(IBusService busService)
        {
            _busService = busService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _busService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("id")]
        public IActionResult GetColorById(int id)
        {
            var result = _busService.GetColorById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost]
        public IActionResult Add(Bus bus)
        {
            var result = _busService.Add(bus);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Bus bus)
        {
            var result = _busService.Update(bus);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(Bus bus)
        {
            var result = _busService.Delete(bus);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
