using Banco.Models;

namespace Banco.Queries
{
    public static class InsuranceCustomerQuery
    {
        public static void RegisterInsuranceCustomer(InsuranceCustomer customer)
        {
            Connection.ExecuteNonQuery($"INSERT INTO insurance_customer(customer_id, customer_fullname, customer_email, customer_phone, customer_address, customer_employment, customer_earning, has_license) " +
                                        $"VALUES('{customer.Id}'," +
                                        $" '{customer.Name}'," +
                                        $"'{customer.Email}'," +
                                        $"'{customer.Phone}'," +
                                        $"'{customer.Address}'," +
                                        $"'{customer.Employment}'," +
                                        $"'{customer.Earnings}'," +
                                        $"'{customer.HasLicense}')");
        }
    }
}
