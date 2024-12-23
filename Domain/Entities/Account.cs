using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// enttity for the account types i.e. banks, person, etc...
namespace Domain.Entities
{
    public class Account
    {
        public long Id { get; set; }

        public long? ParentId { get; set; } // حساب والد (معین) . برای حساب های اصلی یا معین این فیلد در جدول مقداری نمیگیرد
                                            // ام برای سایر حساب ها این آیدی یکی- آیدی یکی از حساب های اصلی است که مقدارش از 
                                            // فیلد Id  دریافت میشود
        [Required]
        public string Name { get; set; }
        public float MaxDebt { get; set; } // حداکثر بدهکاری
        public float MaxCredit { get; set; } // حداکثر طلب
        public bool IsReadOnly { get; set; } = true; // برای حساب های اصلی این مقدار صحیح است . یعنی حساب های اصلی قابل ویرایش نخواهند بود
                                                     // برای سایر حساب ها این مقدار را عوض می کنیم به false
        public bool IsDeleted { get; set; } = false; // for logical removal
        [ForeignKey("ParentId")]
        public Account? Parent { get; set; }

        public List<AccountDetail>? Details { get; set; }
        public List<Payment>? Credits { get; set; } // list of payments that this account has done
        public List<Payment>? Debts { get; set; } // list of payments that this account has received
        public List<InvoiceHeader>? CreditInvoices { get; set; }// list of invoices that the account is a creditor of them
        public List<InvoiceHeader>? DebtInvoices { get; set; }
        public List<AccountingDocumentDetail>? AccountingDocDetails { get; set; }

    }
}
