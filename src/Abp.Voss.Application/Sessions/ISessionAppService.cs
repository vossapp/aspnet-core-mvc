using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Voss.Sessions.Dto;

namespace Abp.Voss.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
