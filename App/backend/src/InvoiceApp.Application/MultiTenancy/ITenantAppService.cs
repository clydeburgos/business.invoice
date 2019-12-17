using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InvoiceApp.MultiTenancy.Dto;

namespace InvoiceApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

