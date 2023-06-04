using System;

namespace Banco.Models
{
    public class CarInsuranceRequest
    {
        public int Id { get; set; }
        public string VehiclePlate { get; set; }
        public string CustomerId { get; set; }
        public string Comment { get; set; }
        public string State { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
