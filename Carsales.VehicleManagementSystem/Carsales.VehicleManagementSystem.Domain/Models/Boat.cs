using System;
using Carsales.VehicleManagementSystem.Data.DbEntities;

namespace Carsales.VehicleManagementSystem.Domain.Models
{
    public class Boat:VehicleBase
    {
        public Boat(string make,string model, double length, string name):base (make,model)
            
        {
            Length = length;
            Name = name;
        }
        public override EVehicleType VehicleType => EVehicleType.Boat;
        public double Length { get; private set; }
        public string Name { get; private set; }

    }
}
