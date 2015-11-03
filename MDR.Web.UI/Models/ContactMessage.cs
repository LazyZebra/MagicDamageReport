using System.ComponentModel.DataAnnotations;

namespace MDR.Web.UI.Models
{
    public class ContactMessage
    {
        [Required]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20")]
        [DataType(DataType.Text, ErrorMessage = "Name can contain letters only")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        [MaxLength(200, ErrorMessage = "Maximum length is 200")]
        [DataType(DataType.MultilineText, ErrorMessage = "Name can contain letters only")]
        public string Message { get; set; }
    }
}
