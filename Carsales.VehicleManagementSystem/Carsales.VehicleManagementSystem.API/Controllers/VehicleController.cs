using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Carsales.VehicleManagementSystem.Data.DbEntities;
using System;

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
        [HttpGet ("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var result = _vehicleService.GetVehicleById(id);
            if(result==null)
            {
                return NotFound("VehicleId is not found");
            }
            
            return Ok(result);
        }

        [HttpGet("type/{type}")]
        public IActionResult GetVehicleByType(string type)
        {
            EVehicleType enumType;
            if (!Enum.TryParse(type, out enumType))
                return BadRequest("invalid vehicle type");
            
                var result = _vehicleService.GetVehicleByType(enumType);
                if (result == null)
                {
                    return NotFound("VehicleType is not found");
                }

                return Ok(result);
            
                
        }

        [HttpPost("car")]
        public IActionResult CreateCar([FromBody] Car car)
        {
            if (
                string.IsNullOrEmpty(car.Make) ||
                string.IsNullOrEmpty(car.Model) ||
                car.Doors <= 0 ||
                car.Wheels <= 0
            )
            {
                return BadRequest("Required information missing.");
            }

            _vehicleService.CreateVehicle(car);
            return Ok();
        }

        [HttpPost("boat")]
        public IActionResult CreateBoat([FromBody] Boat boat)
        {
            if (
          string.IsNullOrEmpty(boat.Make) ||
          string.IsNullOrEmpty(boat.Model) ||
          boat.Length <= 0 
          
      )
            {
                return BadRequest("Required information missing.");
            }

            _vehicleService.CreateVehicle(boat);
            return Ok();
        }

        [HttpPut("boat-{id}")]
        public IActionResult UpdateBoat([FromBody] Boat boat,int id)
        {
            if (string.IsNullOrEmpty(boat.Make) ||
                    string.IsNullOrEmpty(boat.Model) || boat.Length <= 0)
            {
                return BadRequest("Required information missing.");
            }

            if(boat.Id != id)
            {
                return BadRequest("The Id is invalid");
            }

            _vehicleService.UpdateBoatById(boat,id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVehicleById(int id)
        {

            _vehicleService.DeleteVehicleById(id);
          
            return Ok();
        }


    }
}
