using Applicaation.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product
{
    public interface IProductCommands
    {
        public ApiResponse CreateProduct(ProductDTO product);
        public ApiResponse UpdateProduct(ProductDTO product);

        // remove a product if its not being usedany invoice or
        // use logical removal and one can display it in invoice report with a different style
        public ApiResponse DeleteProduct(long productId);
    }
}
