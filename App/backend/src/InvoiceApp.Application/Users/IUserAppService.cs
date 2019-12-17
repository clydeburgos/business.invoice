using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InvoiceApp.Roles.Dto;
using InvoiceApp.Users.Dto;

namespace InvoiceApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
