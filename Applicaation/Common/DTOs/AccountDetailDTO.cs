using Applicaation.Common.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
    public class AccountDetailDTO
    {
        public long Id { get; set; }
        public long AccountId { get; set; } // foreign key
        public string Phone { get; set; } // at least one of the phone or address must be filled, we made phone not nullable
        public string Address { get; set; }
        public AccountDTO Account { get; set; }// this is not nullable
    }
}
