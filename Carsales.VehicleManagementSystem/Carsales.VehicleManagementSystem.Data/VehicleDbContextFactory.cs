using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Carsales.VehicleManagementSystem.Data
{
    public class VehicleDbContextFactory : IDesignTimeDbContextFactory<VehicleContext>
    {
        public VehicleContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VehicleContext>();

            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql("User ID=postgres;Password=mysecretpassword;Server=localhost;Port=5433;Database=VMS;Integrated Security=true;Pooling=true;");

            return new VehicleContext(builder.Options);
        }
    }
}
