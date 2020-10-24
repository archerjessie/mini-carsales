using System;
namespace Carsales.VehicleManagementSystem.Data.DbEntities
{
    public class VehicleDb
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public EVehicleType VehicleType { get; set;}

        public string Engine { get; set; }

        public short Doors { get; set; }

        public short Wheels { get; set; }

        public string BodyType { get; set; }

        public VehicleDb()
        {
        }

      
    }
}
