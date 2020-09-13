using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Carsales.VehicleManagementSystem.Domain.Models;
using Carsales.VehicleManagementSystem.Domain.Repositories;
using Xunit;

namespace Carsales.VehicleManagementSystem.Domain.Test
{
    public class VehicleRepositoryTest
    {
        private readonly IVehicleRepository repo;

        public VehicleRepositoryTest()
        {
            repo = new VehicleRepository();
        }

        [Fact]
        public void GetAllVehicles_ReturnsEmptyCollection()
        {
            var result = repo.GetAllVehicles();

            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void CreateVehicle_ReturnsTrue()
        {
            Car carOne = new Car("toyota","model","engine",4,4,"");

            var result = repo.CreateVehicle(carOne);
            Assert.True(result);
        }

        [Fact]
        public void CreateVehicle_AddVehicleToCollection()
        {
            Car carOne = new Car("toyota", "model", "engine", 4, 4, "");

            repo.CreateVehicle(carOne);
            var result =  repo.GetAllVehicles();

            Assert.Equal(1, result.Count());
            Assert.Equal(1,result.FirstOrDefault().Id);
        }
    }
}
