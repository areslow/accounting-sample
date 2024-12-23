using Application.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;

namespace Application.InvoicePayment
{
    public interface IInvoicePaymentCommands
    {
        public ApiResponse RegisterInvoicePayment(InvoicePaymentDTO invoicePayment);

        // we dont edit an invoice payment . if there is been a mistake we remove it
        //public ApiResponse UpdateInvoicePayment(InvoicePaymentDTO invoicePayment);
        public ApiResponse DeleteInvoicePayment(long id);
    }
}
