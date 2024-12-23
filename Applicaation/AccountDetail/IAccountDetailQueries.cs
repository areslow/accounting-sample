using Application.Common;
using Application.Common.Utilities;

namespace Application.AccountDetail
{
    public interface IAccountDetailQueries
    {
        public ApiResponse GetAccountDetailById(long detailId);
        public ApiResponse GetAccountDetailsByAccountId(long accountId);
    }
}
