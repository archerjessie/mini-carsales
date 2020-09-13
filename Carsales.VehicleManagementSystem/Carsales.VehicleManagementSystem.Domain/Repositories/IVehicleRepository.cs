using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;

namespace Carsales.VehicleManagementSystem.Domain.Repositories
{
    public interface IVehicleRepository
    {
        bool CreateVehicle(VehicleBase vehicle);
        IEnumerable<VehicleBase> GetAllVehicles();
    }
}
