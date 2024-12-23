using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InvoicePayment
    {
        public long Id { get; set; }
        public string InvoiceHeaderId { get; set; }
        public string PaymentId { get; set; }


        [ForeignKey("InvoiceHeaderId")]
        public InvoiceHeader InvoiceHeader { get; set; }
        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }
    }
}
