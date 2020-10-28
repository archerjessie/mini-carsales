using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Data.Repositories;
using Carsales.VehicleManagementSystem.Data.DbEntities;
using System.Linq;
using Carsales.VehicleManagementSystem.Domain.Transformers;

namespace Carsales.VehicleManagementSystem.Domain.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void CreateVehicle(VehicleBase vehicle)
        {
             _vehicleRepository.CreateVehicle(vehicle.ToVehicleDb());
        }

        public IEnumerable<VehicleBase> GetAllVehicles()
        {
            return _vehicleRepository.GetAllVehicles().Select(vehicle => vehicle.ToVehicleBase());
        }

        public VehicleBase GetVehicleById(int id)
        {
            return _vehicleRepository.GetAllVehicles().FirstOrDefault(vehicle => vehicle.Id == id)?.ToVehicleBase();
        }

        public IEnumerable<VehicleBase> GetVehicleByType(EVehicleType type)
        {
            return _vehicleRepository.GetAllVehicles()
                .Where(vehicle => vehicle.VehicleType == type)
                .Select(vehicle => vehicle.ToVehicleBase());
                
        }

        public bool UpdateBoatById(Boat boat,int id)
        {
            //VehicleDb vehicle = _vehicleRepository.GetAllVehicles().FirstOrDefault(vehicle => vehicle.Id == id)


            //if (vehicle.VehicleType != EVehicleType.Boat)
            //{
            //    throw new Exception("error occured when try to add vehicle to database.");
            //}
            VehicleDb vehicle = boat.ToVehicleDb();
            return _vehicleRepository.UpdateVehicle(vehicle);

        }
        public void DeleteVehicleById(int id)
        {
            _vehicleRepository.DeleteVehicleById(id);
        }
    }
}
