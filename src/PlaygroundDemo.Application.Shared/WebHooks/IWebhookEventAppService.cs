using System.Threading.Tasks;
using Abp.Webhooks;

namespace PlaygroundDemo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
