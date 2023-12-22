using System.ComponentModel.DataAnnotations;

namespace PlaygroundDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
