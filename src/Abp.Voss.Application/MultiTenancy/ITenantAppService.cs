using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Voss.MultiTenancy.Dto;

namespace Abp.Voss.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
