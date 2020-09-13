using System;
using System.Collections.Generic;
using Carsales.VehicleManagementSystem.API.Controllers;
using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Carsales.VehicleManagementSystem.API.Test
{
    public class VehicleControllerTest
    {
        private readonly VehicleController _controller;
        private readonly Mock<IVehicleService> _mock;

        public VehicleControllerTest()
        {
           _mock = new Mock<IVehicleService>();
           _controller=new VehicleController(_mock.Object);
        }

        [Fact]
        public void Get_ReturnsCarList()
        {
            var vehicleList = new List<VehicleBase>();
            _mock.Setup(m => m.GetAllVehicles()).Returns(vehicleList);

            var result = _controller.Get();

            Assert.NotNull(result);
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(vehicleList, okResult.Value);
        }

        [Fact]
        public void CreateCar_CallsService()
        {
            Car carOne= new Car("toyota", "model", "engine", 4, 4, "");
            var result = _controller.CreateCar(carOne);
            _mock.Verify(x=>x.CreateVehicle(carOne));
            Assert.NotNull(result); 
            Assert.IsType<OkObjectResult>(result);
        }

        [Theory]
        [InlineData("", "model", 4, 3)]
        [InlineData("Make", "", 4, 3)]
        [InlineData("Make", "model", 0, 3)]
        [InlineData("Make", "model", 4, -1)]
        public void CreateCar_ReturnsBadResult(string make, string model, short doors, short wheels)
        {
            Car car = new Car(make, model, "engine", doors, wheels, "");

            var result = _controller.CreateCar(car);

            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
