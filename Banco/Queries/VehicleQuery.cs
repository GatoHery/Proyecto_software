using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using Banco.Models;

namespace Banco.Queries
{
    public static class VehicleQuery
    {
        public static bool CheckVehicleExist(string vehiclePlate, string issuedToId)
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM insured_vehicle WHERE vehicle_plate = '{vehiclePlate}' AND issued_to_id = '{issuedToId}'");

            if (dt.Rows[0] == null) return false;
            else return true;
        }

        public static Car GetVehicle(string vehiclePlate)
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM insured_vehicle WHERE vehicle_plate = '{vehiclePlate}'");

            Car vehicle = new Car();
            DataRow n = dt.Rows[0];

            vehicle.Make = n[0].ToString();
            vehicle.Model = n[1].ToString();
            vehicle.Year = n[2].ToString();
            vehicle.Plate = n[3].ToString();
            vehicle.Vin = n[4].ToString();
            vehicle.Usage = n[5].ToString();
            vehicle.Value = Convert.ToDecimal(n[6].ToString());
            vehicle.IssuedToId = n[7].ToString();
            vehicle.IsApproved = Convert.ToBoolean(n[8]);

            return vehicle;
        }

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
