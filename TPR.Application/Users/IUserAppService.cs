using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TPR.Roles.Dto;
using TPR.Users.Dto;

namespace TPR.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}