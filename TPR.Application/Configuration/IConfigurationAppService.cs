using System.Threading.Tasks;
using Abp.Application.Services;
using TPR.Configuration.Dto;

namespace TPR.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}