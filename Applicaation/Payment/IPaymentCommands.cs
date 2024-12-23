using Applicaation.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Payment
{
    public interface IPaymentCommands
    {
        public ApiResponse RegisterPayment(PaymentDTO payment);
        public ApiResponse UpdatePayment(PaymentDTO payment);
        public ApiResponse DeletePayment(string paymentId);
    }
}
