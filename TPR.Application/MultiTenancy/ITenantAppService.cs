using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TPR.MultiTenancy.Dto;

namespace TPR.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
