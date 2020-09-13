namespace Carsales.VehicleManagementSystem.Domain.Models
{
    public class Car : VehicleBase
    {
        public Car(string make, string model, string engine, short doors, short wheels, string bodyType) : base(make, model)
        {
            Engine = engine;
            Doors = doors;
            Wheels = wheels;
            BodyType = bodyType;
        }

        public override EVehicleType VehicleType => EVehicleType.Car;

        public string Engine { get; set; }
        public short Doors { get; set; }
        public short Wheels { get; set; }
        public string BodyType { get; set; }
    }
}
