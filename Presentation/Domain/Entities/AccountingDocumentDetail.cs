using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AccountingDocumentDetail
    {
        public long Id { get; set; }
        public long AccountingDocumentId { get; set; }
        public long AccountId { get; set; }

        // if the involving account is creditor the debth is 0 and vice versa
        public float Credit { get; set; }
        public float Debth { get; set; }

        public string? Description { get; set; }

        public bool IsDeleted { get; set; } = false; // for logical removal

        [ForeignKey("AccountingDocumentId")]
        public AccountingDocument Document { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }


    }
}
