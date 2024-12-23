using Applicaation.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;


namespace Application.ApplicationUser
{
    public interface IAuthUser
    {
        public ApiResponse Login(UserDTO user);
        public ApiResponse Logout();
    }
}
