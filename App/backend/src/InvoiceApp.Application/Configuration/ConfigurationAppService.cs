using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using InvoiceApp.Configuration.Dto;

namespace InvoiceApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InvoiceAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
