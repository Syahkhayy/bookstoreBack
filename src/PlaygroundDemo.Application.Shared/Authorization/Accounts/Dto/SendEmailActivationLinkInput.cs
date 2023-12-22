using System.ComponentModel.DataAnnotations;

namespace PlaygroundDemo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}