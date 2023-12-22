using System.Threading.Tasks;
using Abp.Application.Services;
using PlaygroundDemo.MultiTenancy.Payments.PayPal.Dto;

namespace PlaygroundDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
