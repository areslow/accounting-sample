using Applicaation.Common;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Account
{
    public interface IAccountQueries
    {
        public ApiResponse GetAllAccounts(string? searchText = ""); // if the search string is provided it will find account based on the search text
        public ApiResponse GetAccountById(long accountId);
        public ApiResponse GetAccountByName (string accountName);
        public ApiResponse GetAccountsByParent(long parentId);
        //public ApiResponse GetAccounts(string searchText);

    }
}
