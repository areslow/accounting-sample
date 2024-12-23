using Applicaation.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationUser
{
    public interface IUserCommands
    {
        public ApiResponse CreateUser(UserDTO user);
        public ApiResponse UpdateUser(UserDTO user);
        public ApiResponse DeleteUser(string userId); // this better to be logical removal
        // instead of removing user we can activate or deactivate the user
        // by update user method, making the IsActive field true or false
    }
}
