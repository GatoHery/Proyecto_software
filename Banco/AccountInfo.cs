using System;

namespace Banco
{
    public class AccountInfo
    {
        public int id_account { get; set; }
        public string account_name { get; set; }
        public int account_type { get; set; }
        public double account_amount { get; set; }
        public string id_owner { get; set; }
    }
}