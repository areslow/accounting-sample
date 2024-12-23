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
    public class PaymentDTO
    {
        public string? Id { get; set; }
        public string RegisterarId { get; set; }
        public string Date { get; set; }
        public long DebtorId { get; set; }// the one who take money
        public long CreditorId { get; set; }// the one who gives the money

        public long DocId { get; set; } // accounting document ...  سند حسابداری

        public float Value { get; set; } // the amount of the payment

        public string State { get; set; } // credit or debth  دریافت یا پرداخت . can not be null
        public string PaymentType { get; set; } // نقد - کارت با کارت - دستگاه کارت خوان- چک و غیره 
        public string? Description { get; set; }  // توضیحات


        public AccountDTO Debtor { get; set; }
        public AccountDTO Creditor { get; set; }
        public UserDTO Registrar { get; set; }
        public AccountingDocument Document { get; set;}

        public InvoicePaymentDTO? InvoicePayment { get; set; }
    }
}
