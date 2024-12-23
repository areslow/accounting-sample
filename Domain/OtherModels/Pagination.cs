using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OtherModels
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }// number of item per page
        public int TotalRecords { get; set; }
    }
}
