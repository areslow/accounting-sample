using Applicaation.Common.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
    public class InvoiceHeaderDTO
    {
        public string Id { get; set; }
        public string InvoiceNo { get; set; }//  شماره فاکتور
        public string RegistrarId { get; set; }// آیدی کاربر ثبت کننده
        //public long? DocId { get; set; } // آیدی سند حسابداری - برای پیش فاکتور این آیدی موجود نیست
        public string PaymentDate { get; set; }
        public string RegisteringDate { get; set; }
        public string Type { get; set; }// ... توع فاکتور : خرید - فروش- پیش فاکتور - مرجوعی خرید یا فروش و
        public long CreditorId { get; set; } // آیدی حساب بستانکار
        public long DebtorId { get; set; } // آیدی حساب بده کار

        public float TotalPrice { get; set; }
        public float Desicount { get; set; }
        public bool IsConfirmed { get; set; }
        public string? Description { get; set; }

        public AccountDTO Creditor { get; set; }
        public AccountDTO Debtor { get; set; }
        public UserDTO Registrar { get; set; }


        //[ForeignKey("DocId")]
         public AccountingDocumentDTO? Document { get; set;}

        public List<InvoiceDetailDTO> Details { get; set; }

        public List<InvoicePaymentDTO>? Payments { get; set; }
    }
}
