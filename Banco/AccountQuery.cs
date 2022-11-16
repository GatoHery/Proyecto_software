using System;

namespace Banco{
    public static class AccountQuery{
        public static AccountInfo getCustomerAccount(string user_id){
            var dt = Connection.ExecuteQuery($"SELECT * FROM account WHERE customer_id = '{user_id}'");

            AccountInfo account = new AccountInfo();

            account.id_account = Convert.ToInt32(dt.Rows[0].ToString()); // ID cuenta
            account.account_name = dt.Rows[1].ToString(); // Nombre de la cuenta (dueño)
            account.account_type = Convert.ToInt32(dt.Rows[2].ToString()); // Tipo de cuenta
            account.account_amount = Convert.ToDouble(dt.Rows[3].ToString()); // Balance de la cuenta
            account.id_owner = dt.Rows[4].ToString();   // ID dueño de la cuenta

            return account;
        }

        public static void createAccount(AccountInfo account){
            Connection.ExecuteNonQuery($"INSERT INTO account(account_name, account_type, account_amount, customer_id)" +
                                       $"VALUES('{account.account_name}'," +
                                       $"'{account.account_type}'," +
                                       $"'{account.account_amount}'," +
                                       $"'{account.id_owner}')");
        }
    }
}