using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TPR.Configuration.Dto;

namespace TPR.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TPRAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
