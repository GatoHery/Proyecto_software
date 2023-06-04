using System;

namespace Banco.Models
{
    public class CarInsuranceRequest
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public string State { get; set; }
    }
}
