﻿using System.Collections.Generic;
using Abp.Voss.Roles.Dto;

namespace Abp.Voss.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
