using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFines.Models
{
    class ViolationComboBoxModels
    {
        public int ViolationID { get; set; }
        public string? ViolationType { get; set; }
    }
    class CarsComboBoxModels
    {
        public int Carid { get; set; }
        public string? LicensePlate { get; set; }
    }
    class FeeModels
    {
        public int? ViolationFactID { get; set; }
        public string? LicensePlate { get; set; }
        public string? OwnerFullName { get; set; }
        public string? ViolationType { get; set; }
        public decimal? FineAmount { get; set; }
        public DateTime? ViolationDate { get; set; }
        public string? DriverFullName { get; set; }
        public string? RightOfManagement { get; set; }
    }
    class AddFeeModels
    {
        public required int Carid { get; set; }
        public required int ViolationID { get; set; }
        public required DateTime ViolationDate { get; set; }
        public required string DriverFullName { get; set; }
        public required string RightOfManagement { get; set; }

    }
}
