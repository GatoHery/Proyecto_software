using System;
using System.Data;

namespace Banco
{
    public static class AccountQuery
    {
        public static List<AccountInfo> getAllAccounts()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM bank_account");
            List<AccountInfo> allAccounts = new List<AccountInfo>();

            foreach (DataRow n in dt.Rows)
            {
                AccountInfo a = new AccountInfo();

                a.account_number = n[0].ToString();
                a.id_owner = n[4].ToString();

                allAccounts.Add(a);
            }

            return allAccounts;
        }

        public static AccountInfo getCustomerAccount(string account_number, string customer_id)
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM bank_account WHERE account_number = '{account_number}' AND customer_id = '{customer_id}'");

            AccountInfo account = new AccountInfo();

            DataRow n = dt.Rows[0];

            account.account_number = n[0].ToString(); // ID cuenta
            account.account_name = n[1].ToString(); // Nombre de la cuenta (dueño)
            account.id_owner = n[2].ToString(); // ID dueño de la cuenta
            account.account_amount = Convert.ToDouble(n[3].ToString()); // Balance de la cuenta
            account.account_type = Convert.ToChar(n[4].ToString()); // Tipo de cuenta

            return account;
        }

        public static string checkCustomerAccount(string account_number)
        {
            var dt = Connection.ExecuteQuery($"SELECT customer_id FROM bank_account WHERE account_number = '{account_number}'");

            DataRow n = dt.Rows[0];
            string customer_id = n[0].ToString();

            return customer_id;
        }

        public static void createAccount(AccountInfo account)
        {
            Connection.ExecuteNonQuery($"INSERT INTO bank_account(account_number, account_name, customer_id, money_amount, account_type) " +
                                       $"VALUES('{account.account_number}'," +
                                       $"'{account.account_name}'," +
                                       $"'{account.id_owner}'," +
                                       $"{account.account_amount}," +
                                       $"'{account.account_type}')");
        }

        public static void updateAccountBalance(double amount, AccountInfo a)
        {
            Connection.ExecuteNonQuery($"UPDATE bank_account SET money_amount = {amount} " +
                                       $"WHERE account_number = '{a.account_number}' AND customer_id = '{a.id_owner}'");
        }
    }
}