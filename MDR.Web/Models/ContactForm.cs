using System.ComponentModel.DataAnnotations;

namespace MDR.Web.Models
{
    public class ContactForm
    {
        [Required]
        [DataType(DataType.Text)]
        [MinLength(3)]
        [MaxLength(12)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(4)]
        [MaxLength(400)]
        public string Message { get; set; }

    }
}
