using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Data.DbEntities;
using Carsales.VehicleManagementSystem.Data.Repositories;

namespace Carsales.VehicleManagementSystem.Data.Repositories
{
    public interface IVehicleRepository
    {
        IQueryable<VehicleDb> GetAllVehicles();
        void CreateVehicle(VehicleDb vehicle);
        bool UpdateVehicle(VehicleDb Vehicle);
        void DeleteVehicleById(int id);
    }
}
