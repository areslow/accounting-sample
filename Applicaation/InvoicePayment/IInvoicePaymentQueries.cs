using Applicaation.Common;
using Application.Common;
using Application.Common.Utilities;

namespace Application.InvoicePayment
{
    public interface IInvoicePaymentQueries
    {
        public ApiResponse GetInvoicePaymentsByInvoiceId(string invoiceId);
        public ApiResponse GetInvoicePaymentById(long id);
        public ApiResponse GetAllInvoicePayment(SearchModel? searchObj = null); 
    }
}
