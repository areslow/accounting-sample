using Applicaation.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Invoice
{
    public interface IInvoiceCommands
    {
        public ApiResponse CreateInvoice(InvoiceHeaderDTO invoiceHeader, List<InvoiceDetailDTO> details);
        public ApiResponse UpdateInvoice(InvoiceHeaderDTO invoiceHeader); // details can be editted too
        public ApiResponse DeleteInvoice(string  invoiceId);
        public ApiResponse DeleteInvoiceItem(long invoiceDetailId);
    }
}
