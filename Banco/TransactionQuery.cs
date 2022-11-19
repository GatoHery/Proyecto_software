using System;
using System.Data;

namespace Banco{
    public static class TransactionQuery{
        public static void newTransaction(Transaction t){
        Connection.ExecuteNonQuery($"INSERT INTO transaction(date, transaction_amount, account_id, transaction_type)" +
                                   $"VALUES(CURRENT_TIMESTAMP," +
                                   $"{t.transaction_amount}," +
                                   $"{t.account_id}," +
                                   $"{t.transaction_type})");
    }
    }
}