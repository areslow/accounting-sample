using Applicaation.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductGroup
{
    public interface IProductGroupCommands
    {
        public ApiResponse CreateGroup(ProductGroupDTO productGroup);
        public ApiResponse UpdateGroup(ProductGroupDTO productGroup);
        
        
        // approach : if we want to delete a group we first must make sure there is 
        // no product in this group if there is we must remove the product first
        // but we must check first to see if those product is not being used in any invoice 
        // otherwise we musnt let that product be removed and so its group too.
        // an alternate approach is to set IsDeleted field to true >> logical removal !!!
        public ApiResponse DeleteGroup(long id);

    }
}
