using System;

namespace Banco{
    public class Transaction{
        public int id_transaction { get; set; }
        public DateTime date { get; set; }
        public double transaction_amount { get; set; }
        public int account_id { get; set; }
        public int transaction_type { get; set; }
    }
}