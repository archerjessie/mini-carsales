using System;
using Carsales.VehicleManagementSystem.Data.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace Carsales.VehicleManagementSystem.Data
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options)
        {
        }

        public VehicleContext(){}

        public DbSet<VehicleDb> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleDb>().ToTable("Vehicle");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql("User ID=postgres;Password=password;Server=localhost;Port=5433;Database=VMS;Integrated Security=true;Pooling=true;");
    }
}
