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
    public interface IAuthUser
    {
        public ApiResponse Login(UserDTO user);
        public ApiResponse Logout();
    }
}
