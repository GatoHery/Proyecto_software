using System;
using System.Data;
using Banco.Models;

namespace Banco.Queries
{
    public static class TransactionQuery
    {
        public static void newTransaction(Transaction t)
        {
            Connection.ExecuteNonQuery($"INSERT INTO transactions(account_number, transaction_amount, transaction_comment, transaction_type, transaction_date, transaction_hour)" +
                                       $"VALUES('{t.account_number}'," +
                                       $"{t.transaction_amount}," +
                                       $"'{t.transaction_comment}'," +
                                       $"'{t.transaction_type}'," +
                                       $"CURRENT_TIMESTAMP," +
                                       $"CURRENT_TIMESTAMP)");
        }
    }
}