using System;

namespace Banco
{
    public class AccountInfo
    {
        public int id_account { get; set; }
        public string owner_name { get; set; }
        public double money_amount { get; set; }

        public AccountInfo() { }
    }
}