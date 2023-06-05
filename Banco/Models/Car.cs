using System;

namespace Banco.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Plate { get; set; }
        public string Vin { get; set; }
        public string Usage { get; set; }
        public decimal Value { get; set; }
        public string IssuedToId { get; set; }
        public bool IsApproved { get; set; }
    }
}
