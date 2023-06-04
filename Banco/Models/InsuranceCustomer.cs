using System;

namespace Banco.Models
{
    public class InsuranceCustomer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Employment { get; set; }
        public float Earnings { get; set; }
        public bool hasLicense { get; set; }
    }
}
