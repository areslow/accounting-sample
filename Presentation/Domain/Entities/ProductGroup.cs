using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductGroup
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool IsDeleted { get; set; } = false; // for logical removal
        public List<Product>? Products { get; set; }
    }
}
