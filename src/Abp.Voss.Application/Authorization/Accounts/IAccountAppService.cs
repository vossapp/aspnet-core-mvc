using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Voss.Authorization.Accounts.Dto;

namespace Abp.Voss.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
