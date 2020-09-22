using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Domain.Repositories;
using Carsales.VehicleManagementSystem.Domain.Services;
using Xunit;
using Moq;

namespace Carsales.VehicleManagementSystem.Domain.Test
{
    public class VehicleServiceTest
    {
        private readonly VehicleService _service;
        private readonly Mock<IVehicleRepository> _mockRepository;

        public VehicleServiceTest()
        {
            _mockRepository = new Mock<IVehicleRepository>();
            _service = new VehicleService(_mockRepository.Object);
        }

        [Fact]
        public void GetAllVehicles_CallsRepository()
        {
            _service.GetAllVehicles();

            _mockRepository.Verify(x => x.GetAllVehicles());
        }

        [Fact]
        public void CreateVehicle_CallsRepository()
        {
            Car carOne = new Car("toyota","model","engine",4,4,"");

            _service.CreateVehicle(carOne);
            _mockRepository.Verify(x => x.CreateVehicle(carOne));
        }
    }
}
