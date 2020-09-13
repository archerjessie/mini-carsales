using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;

namespace Carsales.VehicleManagementSystem.Domain.Services
{
    public interface IVehicleService
    {
        bool CreateVehicle(VehicleBase vehicle);
        IEnumerable<VehicleBase> GetAllVehicles();
    }
}
