using System.Threading.Tasks;
using Abp.Voss.Configuration.Dto;

namespace Abp.Voss.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
