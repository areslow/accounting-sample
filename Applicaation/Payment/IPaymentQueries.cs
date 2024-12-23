using Applicaation.Common;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Payment
{
    public interface IPaymentQueries
    {
        public ApiResponse GetAllPayments();
        //public ApiResponse GetPaymentsByDate(string date);
        public ApiResponse GetPaymentById(string payment);

        /// <summary>
        /// find all payment between to date based on their type( credit or debth)
        /// </summary>
        /// <param name="accountId"> id of the account that payment belongs to</param>
        /// <param name="start"> starting date</param>
        /// <param name="end">ending date</param>
        /// <param name="state">state coude be credit or debth. leave an empty string if you 
        /// need to get all payments between start and end date</param>
        /// <returns></returns>
        public ApiResponse FilterPayments(long accountId, string startDate, string endDate, string state);

    }
}
