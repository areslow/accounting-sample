using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
    public class InvoiceDetailDTO
    {
        public long Id { get; set; }
        public string InvoiceHeaderId { get; set; }
        public long ProductId { get; set; }

        public float UnitPrice { get; set; } // we can get this from product table but as it may change during time 
                                             // we put it here when registernig the invoice.
        public float Volume { get; set; } // setting it as float to cover items that asessed by their weight
        //public string UnitType { get; set; } // kg, count,... واحد شمارش : گیلو گرم یا تعداد یا هر واحدی

        public InvoiceHeader InvoiceHeader { get; set; }
        public ProductDTO Product { get; set; }
    }
}
