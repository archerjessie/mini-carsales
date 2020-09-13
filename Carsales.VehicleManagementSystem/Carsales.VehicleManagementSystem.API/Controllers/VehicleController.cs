using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carsales.VehicleManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _vehicleService.GetAllVehicles();
            return Ok(result);
        }

        [HttpPost("car")]
        public IActionResult CreateCar([FromBody]Car car)
        {
            if (string.IsNullOrEmpty(car.Make) || string.IsNullOrEmpty(car.Model) || car.Doors<=0 || car.Wheels <=0)
            {
                return BadRequest("Required information missing.");
            }
            
            bool result = _vehicleService.CreateVehicle(car);
            return Ok(result);
        }
    }
}
