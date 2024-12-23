using Applicaation.Common;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductGroup
{
    public interface IProductGroupQueries
    {
        public ApiResponse GetAllGroups();
        public ApiResponse GetGroupById(long id);
    }
}
