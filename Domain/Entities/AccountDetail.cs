using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// this entity define the details for an account
// any record of this entity belongs to a specific account
// so AccountId is needed to be able to assign the details to the account

namespace Domain.Entities
{
    public class AccountDetail
    {
        public long Id { get; set; }
        public long AccountId { get; set; } // foreign key
        public string Phone { get; set; } // at least one of the phone or address must be filled, we made phone not nullable
        public string Address { get; set; }
        public bool IsDeleted { get; set; } = false; // for logical removal
        [ForeignKey("AccountId")]
        public Account Account { get; set; }// this is not nullable
    }
}
