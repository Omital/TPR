using System.Threading.Tasks;
using Abp.Application.Services;
using TPR.Authorization.Accounts.Dto;

namespace TPR.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
