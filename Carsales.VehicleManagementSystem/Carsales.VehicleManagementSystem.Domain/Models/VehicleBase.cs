using Carsales.VehicleManagementSystem.Data.DbEntities;

namespace Carsales.VehicleManagementSystem.Domain.Models
{
    public abstract class VehicleBase
    {
        public abstract EVehicleType VehicleType { get; }
        public string VehicleTypeString => VehicleType.ToString();

        public int Id { get; set; }
        public string Make { get; private set; }
        public string Model { get; private set; }

        protected VehicleBase(string make, string model)
        {
            Make = make;
            Model = model;
        }
    }
}
