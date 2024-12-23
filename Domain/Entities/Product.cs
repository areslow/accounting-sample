using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public long Id { get; set; }
        [Required]
        public long GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }

        //[RatingRange]// this can be used to check if this fiel has a value between 0 and 5 by stpe =  0.5
        //[Range(0, 5, ErrorMessage = "rating must be between 0 and 5")]
        //public float? Rating { get; set; }

        public bool IsDeleted { get; set; } = false; // for logical removal

        [ForeignKey("GroupId")]
        public ProductGroup Group { get; set; }

        public List<InvoiceDetail>? InvoiceDetails { get; set; }
    }
}
