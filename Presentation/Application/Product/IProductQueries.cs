using Applicaation.Common;
using Application.Common;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product
{
    public interface IProductQueries
    {
        public ApiResponse GetAllProducts();
        public ApiResponse GetProductById(long id);
        public ApiResponse GetProductsByName(string name);
        public ApiResponse GetProductsByGroupName(string groupName);
        public ApiResponse GetProductsByGroupId(string groupName);
        
        /// <summary>
        /// find all products that meet provided options
        /// </summary>
        /// <param name="searchObj"> a search model which contains a search text(can be name or anything) 
        /// max price and min price, if need a specific price both value can be the same
        /// and other properties. check SearchModel class
        /// </param>
        /// <returns>all products that meet provided search options</returns>
        public ApiResponse GetProductsByCriteria(SearchModel searchObj);
    }
}
