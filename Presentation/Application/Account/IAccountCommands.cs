using Applicaation.Common.DTOs;
using Application.Common.Utilities;

namespace Application.Account
{
    public interface IAccountCommands
    {
        public Task<ApiResponse> CreateAccountAsync(AccountDTO account);
        public Task<ApiResponse> UpdateAccountAsync(AccountDTO account);
        public Task<ApiResponse> DeleteAccountAsync(long accountId);
    }
}
