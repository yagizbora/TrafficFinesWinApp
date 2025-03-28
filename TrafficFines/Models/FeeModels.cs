﻿namespace TrafficFines.Models
{
    class ViolationComboBoxModels
    {
        public int? ViolationID { get; set; }
        public string? ViolationType { get; set; }
    }
    class CarsComboBoxModels
    {
        public int? Carid { get; set; }
        public string? LicensePlate { get; set; }
    }
    class FeeModels
    {
        public int? ViolationFactID { get; set; }
        public string? LicensePlate { get; set; }
        public string? OwnerFullName { get; set; }
        public string? ViolationType { get; set; }
        public string? ViolationDetection { get; set; }
        public decimal? FineAmount { get; set; }
        public DateTime? ViolationDate { get; set; }
        public string? DriverFullName { get; set; }
        public string? RightOfManagement { get; set; }
        public bool? is_paid { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime? ViolationPaymentDate { get; set; }
        public string? DiscountOrPenaltyReason { get; set; }
    }
    class AddFeeModels
    {
        public required int Carid { get; set; }
        public required int? ViolationID { get; set; }
        public required DateTime ViolationDate { get; set; }
        public string? ViolationDetection { get; set; }
        public required string DriverFullName { get; set; }
        public required string RightOfManagement { get; set; }
        public required decimal FineAmount { get; set; }
    }
    class EditViolationComboBoxModels
    {
        public int? ViolationID { get; set; }
        public string? ViolationType { get; set; }
    }
    class EditCarsComboBoxModels
    {
        public int? Carid { get; set; }
        public string? LicensePlate { get; set; }
    }
    class GetEditData
    {
        public int? ViolationFactID { get; set; }
        public int? carId { get; set; }
        public int? violationId { get; set; }
        public DateTime? ViolationDate { get; set; }
        public string? ViolationDetection { get; set; }
        public string? DriverFullName { get; set; }
        public string? RightOfManagement { get; set; }
        public decimal? FineAmount { get; set; }
    }
    class EditFeeModels
    {
        public int? ViolationFactID { get; set; }
        public required int Carid { get; set; }
        public required int? ViolationID { get; set; }
        public string? ViolationDetection { get; set; }
        public required DateTime ViolationDate { get; set; }
        public required string DriverFullName { get; set; }
        public required string RightOfManagement { get; set; }
        public required decimal FineAmount { get; set; }
    }
}
