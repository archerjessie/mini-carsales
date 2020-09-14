using System.Collections.Generic;
using System.Linq;
using Carsales.VehicleManagementSystem.Domain.Models;

namespace Carsales.VehicleManagementSystem.Domain.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IList<VehicleBase>
            _vehicleList = new List<VehicleBase>();

        public bool CreateVehicle(VehicleBase vehicle)
        {
            vehicle.Id = _vehicleList.Count() + 1;

            _vehicleList.Add (vehicle);
            return true;
        }

        public IEnumerable<VehicleBase> GetAllVehicles()
        {
            return _vehicleList;
        }
    }
}
