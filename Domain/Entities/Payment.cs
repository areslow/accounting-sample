using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  دریافت و پرداخت ها
namespace Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string RegisterarId { get; set; }
        public string Date { get; set; }
        public long DebtorId { get; set; }// the one who take money
        public long CreditorId { get; set; }// the one who gives the money

        public long DocId { get; set; } // accounting document ...  سند حسابداری

        public float Value { get; set; } // the amount of the payment

        public string State { get; set; } // credit or debth  دریافت یا پرداخت . can not be null
        public string PaymentType { get; set; } // نقد - کارت با کارت - دستگاه کارت خوان- چک و غیره 
        public string? Description { get; set; }  // توضیحات

        public bool IsDeleted { get; set; } = false; // for logical removal

        [ForeignKey("DebtorId")]
        public Account Debtor { get; set; }
        [ForeignKey("CreditorId")]
        public Account Creditor { get; set; }
        [ForeignKey("RegisterarId")]
        public ApplicationUser Registrar { get; set; }

        [ForeignKey("DocId")]
        public AccountingDocument Document { get; set; }

        public InvoicePayment? InvoicePayment { get; set; }
    }

}
