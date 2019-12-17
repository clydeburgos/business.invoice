using System.Threading.Tasks;
using Abp.Application.Services;
using InvoiceApp.Sessions.Dto;

namespace InvoiceApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
