using System;

namespace Banco.Models
{
    public class Transaction
    {
        public string transaction_number { get; set; }
        public string account_number { get; set; }
        public double transaction_amount { get; set; }
        public string? transaction_comment { get; set; }
        public char transaction_type { get; set; }
        public DateTime transaction_date { get; set; }
        public DateTime transaction_time { get; set; }
    }
}