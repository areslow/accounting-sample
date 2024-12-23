using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InvoiceHeader
    {
        public string Id { get; set; } = new Guid().ToString();
        public string InvoiceNo { get; set; }//  شماره فاکتور
        public string RegisterarId { get; set; }// آیدی کاربر ثبت کننده
        public long? DocId { get; set; } // آیدی سند حسابداری - برای پیش فاکتور این آیدی موجود نیست
        public string PaymentDate { get; set; }
        public string RegisteringDate { get; set; }
        public string Type { get; set; }// ... توع فاکتور : خرید - فروش- پیش فاکتور - مرجوعی خرید یا فروش و
        public long CreditorId { get; set; } // آیدی حساب بستانکار
        public long DebtorId { get; set; } // آیدی حساب بدهکار

        public float Desicount { get; set; }
        public bool IsConfirmed { get; set; }
        public string? Description { get; set; }

        public bool IsDeleted { get; set; } = false; // for logical removal


        [ForeignKey("CreditorId")]
        public Account Creditor { get; set; }
        [ForeignKey("DebtorId")]
        public Account Debtor { get; set; }
        [ForeignKey("RegisterarId")]
        public ApplicationUser Registerar { get; set; }


        [ForeignKey("DocId")]
        public AccountingDocument? Document { get; set;}

        public List<InvoiceDetail> Details { get; set; }

        public List<InvoicePayment>? InvoicePayments { get; set; }

    }
}
