using System;
using System.Data;
using Banco.Models;

namespace Banco.Queries
{
    public static class VehicleQuery
    {
        public static void AddInsuredVehicle(Car vehicle)
        {
            Connection.ExecuteNonQuery($"INSERT INTO insured_vehicle(vehicle_make, vehicle_model, vehicle_year, vehicle_plate, vehicle_vin, vehicle_usage, car_value, issued_to_id, insurance_accepted) " +
                                        $"VALUES('{vehicle.Make}'," +
                                        $" '{vehicle.Model}'," +
                                        $"'{vehicle.Year}'," +
                                        $"'{vehicle.Plate}'," +
                                        $"'{vehicle.Vin}'," +
                                        $"'{vehicle.Usage}'," +
                                        $"'{vehicle.Value}'," +
                                        $"'{vehicle.IssuedToId}'," +
                                        $"'{vehicle.IsApproved}')");
        }
    }
}
