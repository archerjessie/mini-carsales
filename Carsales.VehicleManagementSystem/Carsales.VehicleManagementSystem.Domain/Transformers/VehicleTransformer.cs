using System;
using System.Diagnostics;
using Carsales.VehicleManagementSystem.Data.DbEntities;
using Carsales.VehicleManagementSystem.Domain.Models;

namespace Carsales.VehicleManagementSystem.Domain.Transformers
{
    
    public static class VehicleTransformer
    {
        public static VehicleDb ToVehicleDb(this VehicleBase vehicleBase)
        {
            VehicleDb vehicleDb = new VehicleDb()
            {
                Id = vehicleBase.Id,
                Make = vehicleBase.Make,
                Model = vehicleBase.Model,
                VehicleType = EVehicleType.Car
            };

            Car car = vehicleBase as Car;
            if (car != null)
            {
                vehicleDb.Engine = car.Engine;
                vehicleDb.Doors = car.Doors;
                vehicleDb.Wheels = car.Wheels;
                vehicleDb.BodyType = car.BodyType;
            }

            Boat boat = vehicleBase as Boat;
            if(boat !=null)
            {
                vehicleDb.Length = boat.Length;
                vehicleDb.Name = boat.Name;
                vehicleDb.VehicleType = EVehicleType.Boat;
            }
            return vehicleDb;

        }

        public static VehicleBase ToVehicleBase(this VehicleDb vehicleDb)
        {

            switch (vehicleDb.VehicleType)
            {
                case EVehicleType.Car:

                    Car car = new Car(vehicleDb.Make, vehicleDb.Model, vehicleDb.Engine, vehicleDb.Doors, vehicleDb.Wheels, vehicleDb.BodyType)
                    {
                        Id = vehicleDb.Id

                    };
                    return car;

                case EVehicleType.Boat:
                    Boat boat = new Boat(vehicleDb.Make,vehicleDb.Model,vehicleDb.Length, vehicleDb.Name)
                    {
                        Id = vehicleDb.Id
                    };
                    return boat;
                default:
                    throw new Exception("inefficient vehicle type");
            }


    }   }
}
