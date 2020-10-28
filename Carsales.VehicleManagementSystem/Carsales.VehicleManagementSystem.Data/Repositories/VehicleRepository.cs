using System;
using System.Collections.Generic;
using System.Linq;
using Carsales.VehicleManagementSystem.Data;
using Carsales.VehicleManagementSystem.Data.DbEntities;
using Carsales.VehicleManagementSystem.Data.Exceptions;
using Carsales.VehicleManagementSystem.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Carsales.VehicleManagementSystem.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleContext _context;

        public VehicleRepository(VehicleContext context)
        {
            _context = context;
        }

        public IQueryable<VehicleDb> GetAllVehicles()
        {
            return _context.Vehicles;
        }

        public void CreateVehicle(VehicleDb vehicle)
        {
            _context.Add(vehicle);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new DBOperationException(ex);
            }
        }

        public bool UpdateVehicle(VehicleDb Vehicle)
        {
            _context.Entry(Vehicle).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (_context.Vehicles.Any(v => v.Id == Vehicle.Id))
                {
                    return false;
                }
                else
                {
                    throw new VehicleNotExistException(e);
                }
            }
            catch (Exception ex)
            {
                throw new DBOperationException(ex);
            }
        }

        public void DeleteVehicleById(int id)
        {
            var vehicle = new VehicleDb()
            {
                Id = id
            };
            _context.Remove(vehicle);

            try
            {

                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return;
            }

        }
    }
}
