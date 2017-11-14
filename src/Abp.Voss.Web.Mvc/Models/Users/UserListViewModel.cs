using System.Collections.Generic;
using Abp.Voss.Roles.Dto;
using Abp.Voss.Users.Dto;

namespace Abp.Voss.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}