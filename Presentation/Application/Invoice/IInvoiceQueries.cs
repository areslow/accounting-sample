using Applicaation.Common;
using Application.Common;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Invoice
{
    public interface IInvoiceQueries
    {

        public ApiResponse GetAllInvoice();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="type"></param>
        /// <returns> list of invoice headers</returns>
        public ApiResponse GetInvoicesByAccountId(long accountId, string type);
        public ApiResponse GetInvoicesByAccountName(string accountName, string type);

        /// <summary>
        /// Search all invoices to find invoices with specified conditions like :
        /// dates, seasrch string ,...
        /// </summary>
        /// <param name="startDate"> startting date</param>
        /// <param name="endDate">endintg date, to get invoices for a single date 
        /// endDate must be equal to startDate</param>
        /// <param name="type">type of invoice :  ...خرید-فروش-پیش فاکتور و</param>
        /// <param name="accountId">accountId of the customer the invoices are belong to</param>
        /// <param name="searchText">a string that invoices may contains ,</param>
        /// <returns></returns>
        public ApiResponse SearchInvoices(SearchModel searchObj); //accountId = 0 means search amongst all account
    
        /// <summary>
        /// this method returns the details of an invoice i.e List<InvoiceDetailDTO>
        /// </summary>
        /// <param name="invoiced">id of the invoice to be returned</param>
        /// <returns> a single invoice with id of the given id</returns>
        public ApiResponse GetInvoiceById(string invoiced);
    
    }
}
