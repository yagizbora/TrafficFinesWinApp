using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFines.Models
{
    class ViolationModel
    {
        public int? id { get; set; }
        public string? ViolationType { get; set; }
        public decimal? FineAmount { get; set; }

    }
    class AddViolationModel
    {
        public string? ViolationType { get; set; }
        public decimal? FineAmount { get; set; }
    }
    class GetViolationModel
    {
        public int? id { get; set; }
        public string? ViolationType { get; set; }
        public decimal? FineAmount { get; set; }
    }
    class EditViolationModel
    {
        public string? id { get; set; }
        public string? ViolationType { get; set; }
        public decimal? FineAmount { get; set; }
    }
    class DeleteViolationTypeModel
    {
        public required string Id { get; set; }
    }
    // FEE OPERATIONS

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
