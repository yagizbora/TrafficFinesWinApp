using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFines.Models
{
    class ViolationComboBoxModels
    {
        public int? ViolationID { get; set; }
        public string? ViolationType { get; set; }
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
}
