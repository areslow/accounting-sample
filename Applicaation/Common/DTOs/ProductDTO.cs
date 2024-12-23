using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }

        //[RatingRange]// this can be used to check if this fiel has a value between 0 and 5 by stpe =  0.5
        //[Range(0, 5, ErrorMessage = "rating must be between 0 and 5")]
        public float? Rating { get; set; }
        public ProductGroupDTO Group { get; set; }
        public List<InvoiceDetailDTO>? InvoiceDetails { get; set; }
    }
}
