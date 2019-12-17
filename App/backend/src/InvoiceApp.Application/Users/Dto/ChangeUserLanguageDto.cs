using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}