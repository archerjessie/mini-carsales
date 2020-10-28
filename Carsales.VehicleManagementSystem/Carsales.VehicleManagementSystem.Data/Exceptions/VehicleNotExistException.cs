using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;

namespace Carsales.VehicleManagementSystem.Data.Exceptions
{
    public class VehicleNotExistException : Exception
    {
        public VehicleNotExistException(DbUpdateConcurrencyException updateConcurrencyException) : base("Vehicle not exist.", updateConcurrencyException)
        {
        }
    }
}
