using Banco.Models;
using System.Data;

namespace Banco.Queries
{
    public static class InsuranceCustomerQuery
    {
        public static bool CheckCustomerExist(string customerId)
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM insurance_customer WHERE customer_id = '{customerId}'");

            if (dt.Rows[0] == null) return false;
            else return true;
        }

        public static InsuranceCustomer GetInsuranceCustomer(string customerId)
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM insurance_customer WHERE customer_id = '{customerId}'");

            InsuranceCustomer customer = new InsuranceCustomer();
            DataRow n = dt.Rows[0];

            customer.Id = n[0].ToString();
            customer.Name = n[1].ToString();
            customer.Email = n[2].ToString();
            customer.Phone = n[3].ToString();
            customer.Address = n[5].ToString();
            customer.Employment = n[6].ToString();
            customer.Earnings = Convert.ToDecimal(n[7].ToString());
            customer.HasLicense = Convert.ToBoolean(n[8]);

            return customer;
        }

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
