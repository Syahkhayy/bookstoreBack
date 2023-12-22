using System.Threading.Tasks;
using PlaygroundDemo.Authorization.Users;

namespace PlaygroundDemo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
