

namespace Application.Common.DTOs
{
    public class InvoicePaymentDTO
    {
        public long Id { get; set; }
        public string InvoiceHeaderId { get; set; }
        public string PaymentId { get; set; }


        public InvoiceHeaderDTO InvoiceHeader { get; set; }
        public PaymentDTO Payment { get; set; }
    }
}
