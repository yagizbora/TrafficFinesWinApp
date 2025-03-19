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

}
