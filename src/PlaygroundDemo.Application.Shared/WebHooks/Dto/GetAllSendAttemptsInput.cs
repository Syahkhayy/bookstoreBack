using PlaygroundDemo.Dto;

namespace PlaygroundDemo.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
