using System;
namespace Carsales.VehicleManagementSystem.Data.Exceptions
{
    public class DBOperationException : Exception
    {
        public DBOperationException(Exception ex) : base("error occured when try to add vehicle to database.", ex) 
        {
        }
    }
}
