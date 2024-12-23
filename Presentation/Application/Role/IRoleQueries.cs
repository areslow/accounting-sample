using Applicaation.Common;
using Application.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Role
{
    public interface IRoleQueries
    {
        public ApiResponse GetAllRoles(string roleName = "");
        public ApiResponse GetRoleById(string roleId);
    }
}
