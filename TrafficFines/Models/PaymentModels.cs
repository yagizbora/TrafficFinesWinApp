using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFines.Models
{
    class GetPaymentModels
    {
        public required int ViolationFactID { get; set; }
    }
    class PaymentModels
    {
        public required int ViolationFactID { get; set; }
        public required DateTime ViolationDate { get; set; }
        public required string DriverFullName { get; set; }
        public required decimal FineAmount { get; set; }
        public required string Model { get; set; }
        public required string ViolationType { get; set; }
        public required bool is_paid { get; set; }
    }
    class PaymmentFineModels
    {
        public required int ViolationFactID { get; set; }
        public required bool is_paid { get; set; }
        public required string PaymentMethod { get; set; }
        public required string ReceiptNumber { get; set; }
        public required string ViolationPayment { get; set; }
        public required DateTime ViolationPaymentDate { get; set; }
        public required string PaymentAmount { get; set; }
    }

}
