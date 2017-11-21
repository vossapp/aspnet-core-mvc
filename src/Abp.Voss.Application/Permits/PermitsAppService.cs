using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Voss.MultiTenancy;
using Abp.Voss.Authorization.Users;

namespace Abp.Voss.Permits
{
    public class PermitsAppService: IPermitsAppService
    {
        private readonly IRepository<Tenant> _tenantRepository;
        private readonly IRepository<User, long> _userRepository;

        public PermitsAppService(
              IRepository<Tenant> tenantRepository,
              IRepository<User, long> userRepository
            )
        {
            _tenantRepository = tenantRepository;
            _userRepository = userRepository;
        }



    }
}
