using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Abp.Voss.Configuration.Dto;

namespace Abp.Voss.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VossAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
