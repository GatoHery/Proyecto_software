using Banco.Models;

namespace Banco.Queries
{
    public class CarInsuranceRequestQuery
    {
        public static void NewRequest(CarInsuranceRequest request)
        {
            Connection.ExecuteNonQuery($"INSERT INTO vehicle_insurance_request(request_date, vehicle_id, customer_id, request_comments, request_state) " +
                                        $"VALUES(CURRENT_DATE," +
                                        $" '{request.VehiclePlate}'," +
                                        $" '{request.CustomerId}'," +
                                        $"'{request.Comment}'," +
                                        $"'{request.State}')");
        }
    }
}
