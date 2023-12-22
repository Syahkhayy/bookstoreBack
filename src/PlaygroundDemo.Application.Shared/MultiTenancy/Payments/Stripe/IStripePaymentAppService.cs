using System.Threading.Tasks;
using Abp.Application.Services;
using PlaygroundDemo.MultiTenancy.Payments.Dto;
using PlaygroundDemo.MultiTenancy.Payments.Stripe.Dto;

namespace PlaygroundDemo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}