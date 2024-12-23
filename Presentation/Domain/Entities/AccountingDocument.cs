using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AccountingDocument
    {
        public long Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public bool IsConfirmed { get; set; }

        public bool IsDeleted { get; set; } = false; // for logical removal

        public List<AccountingDocumentDetail>? DocumentDetails { get; set; }
    }
}
