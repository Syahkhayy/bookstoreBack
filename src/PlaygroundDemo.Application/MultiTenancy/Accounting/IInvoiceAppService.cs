using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PlaygroundDemo.MultiTenancy.Accounting.Dto;

namespace PlaygroundDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
