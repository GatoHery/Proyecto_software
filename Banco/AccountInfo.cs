using System;

namespace Banco
{
    public class AccountInfo
    {
        public string account_number { get; set; }
        public string account_name { get; set; }
        public string id_owner { get; set; }
        public double account_amount { get; set; }
        public char account_type { get; set; }
    }
}