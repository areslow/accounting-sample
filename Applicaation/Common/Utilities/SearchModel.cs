using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Utilities
{
    // this is a search model for payments, invoices
    public class SearchModel
    {

        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public long? AccountId { get; set; }
        public string? Type { get; set; }
        public string? State { get; set; }
        public string? SearchText { get; set; }
        public float? MinPrice { get; set; }
        public float? MaxPrice { get; set; }
    }
}
