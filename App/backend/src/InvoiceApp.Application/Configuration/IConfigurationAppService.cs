using System.Threading.Tasks;
using InvoiceApp.Configuration.Dto;

namespace InvoiceApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
