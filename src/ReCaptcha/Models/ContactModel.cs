using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace ReCaptcha.Models
{
    public class ContactModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email{ get; set; }

        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please click on the 'I\'m not a robot' box at the bottom of the page")]
        [FromForm(Name = "g-recaptcha-response")]
        public string ReCaptcha { get; set; }
    }
}
