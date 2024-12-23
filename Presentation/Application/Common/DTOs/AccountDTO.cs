using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTOs;

namespace Applicaation.Common.DTOs
{
    public class AccountDTO
    {
        public long? Id { get; set; }
        public long? ParentId { get; set; } 
        public string Name { get; set; }
        //public string ParentName { get; set; } this can be retrived by the
        // parent object. or we can remove the parent object and retrive the name of parent an putinto this field.
        public float MaxDebt { get; set; } 
        public float MaxCredit { get; set; } 
        public bool IsReadOnly { get; set; } = true;
        public AccountDTO? Parent { get; set; }

        public List<AccountDetailDTO> Details { get; set; } = new();
        public List<PaymentDTO> Credits { get; set; } = new();
        public List<PaymentDTO> Debts { get; set; } = new();
    }
}
