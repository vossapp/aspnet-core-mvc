using System.ComponentModel.DataAnnotations;

namespace Abp.Voss.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}