using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Domain.Repositories;

namespace Carsales.VehicleManagementSystem.Domain.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public bool CreateVehicle(VehicleBase vehicle)
        {
            return _vehicleRepository.CreateVehicle(vehicle);
        }

        public IEnumerable<VehicleBase> GetAllVehicles()
        {
            return _vehicleRepository.GetAllVehicles();
        }
    }
}
