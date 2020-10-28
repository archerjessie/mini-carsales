using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Data.DbEntities;

namespace Carsales.VehicleManagementSystem.Domain.Services
{
    public interface IVehicleService
    {
        void CreateVehicle(VehicleBase vehicle);
        IEnumerable<VehicleBase> GetAllVehicles();
        VehicleBase GetVehicleById(int id);
        IEnumerable<VehicleBase> GetVehicleByType(EVehicleType type);
        bool UpdateBoatById(Boat boat, int id);
        void DeleteVehicleById(int id);
    }
}
