using Applicaation.Common;
using Application.Common.DTOs;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Role
{
    public interface IRoleCommands
    {
        public ApiResponse CreateRole(RoleDTO role);
        public ApiResponse UpdateRole(RoleDTO role);

        // removing a role completely . no need to keep and hide it.
        public ApiResponse DeleteRole(RoleDTO role);
        public ApiResponse AssignRoleToUser(RoleDTO role, UserDTO user);// can use role id and user id instead
    }
}
