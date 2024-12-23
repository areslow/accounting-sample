using Application.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;

namespace Application.AccountDetail
{
    public interface IAccountDetailCommands
    {
        public ApiResponse CreateAccountDetail(AccountDetailDTO detail);
        public ApiResponse UpdateAccountDetail(AccountDetailDTO detail);
        public ApiResponse DeleteAccountDetail(string accountDetailId);

    }
}
