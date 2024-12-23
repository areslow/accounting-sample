using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public List<InvoiceHeader>? Invoices { get; set; }
        public List<Payment>? Payments { get; set; }
        public bool IsDeleted { get; set; } = false; // for logical removal

    }
}
