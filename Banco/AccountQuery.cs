using System;
using System.Data;

namespace Banco{
    public static class AccountQuery{
        public static List<AccountInfo> getAllAccounts(){
            var dt = Connection.ExecuteQuery($"SELECT * FROM account");
            List<AccountInfo> allAccounts = new List<AccountInfo>();

            foreach(DataRow n in dt.Rows){
                AccountInfo a = new AccountInfo();

                a.id_account = Convert.ToInt32(n[0].ToString());
                a.id_owner = n[4].ToString();

                allAccounts.Add(a);
            }

            return allAccounts;
        }

        public static AccountInfo getCustomerAccount(string user_id, int account_id){
            var dt = Connection.ExecuteQuery($"SELECT * FROM account WHERE customer_id = '{user_id}' AND account_id = {account_id}");

            AccountInfo account = new AccountInfo();

            foreach(DataRow n in dt.Rows){

            account.id_account = Convert.ToInt32(n[0].ToString()); // ID cuenta
            account.account_name = n[1].ToString(); // Nombre de la cuenta (dueño)
            account.account_type = Convert.ToInt32(n[2].ToString()); // Tipo de cuenta
            account.account_amount = Convert.ToDouble(n[3].ToString()); // Balance de la cuenta
            account.id_owner = n[4].ToString(); // ID dueño de la cuenta
            }

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