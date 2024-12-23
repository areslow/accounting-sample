using Applicaation.Common.DTOs;
using Applicaation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Utilities;

namespace Application.Account
{
    public interface IAccountCommands
    {
        public ApiResponse CreateAccount(AccountDTO account);
        public ApiResponse UpdateAccount(AccountDTO account);
        public ApiResponse DeleteAccount(long accountId);
    }
}
