using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
    public class ProductGroupDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<ProductDTO>? Products { get; set; }
    }
}
