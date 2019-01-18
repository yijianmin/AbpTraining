using System.ComponentModel.DataAnnotations;

namespace AbpTraining.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}