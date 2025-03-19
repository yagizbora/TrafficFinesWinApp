namespace TrafficFines.Models
{
    class CarModels
    {
        public int? Carid { get; set; }
        public string? Model { get; set; }
        public int? YearOfRelease { get; set; }
        public string? LicensePlate { get; set; }
        public decimal? InsurableValue { get; set; }
        public string? OwnerFullName { get; set; }
        public string? OwnerPassportData { get; set; }
    }
    class AddCarModels
    {
        public string? Model { get; set; }
        public int? YearOfRelease { get; set; }
        public string? LicensePlate { get; set; }
        public decimal? InsurableValue { get; set; }
        public string? OwnerFullName { get; set; }
        public string? OwnerPassportData { get; set; }
    }
    class EditDataCarModels
    {
        public string? Carid { get; set; }
        public string? Model { get; set; }
        public int? YearOfRelease { get; set; }
        public string? LicensePlate { get; set; }
        public decimal? InsurableValue { get; set; }
        public string? OwnerFullName { get; set; }
        public string? OwnerPassportData { get; set; }
    }
    class SendEditDataCarModels
    {
        public string? Carid { get; set; }
        public string? Model { get; set; }
        public int? YearOfRelease { get; set; }
        public string? LicensePlate { get; set; }
        public decimal? InsurableValue { get; set; }
        public string? OwnerFullName { get; set; }
        public string? OwnerPassportData { get; set; }
    }
    class DeleteCarModels
    {
        public string? Carid { get; set; }
    }
}
