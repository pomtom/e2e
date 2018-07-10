using System.ComponentModel.DataAnnotations;

namespace e2eapi.Models
{
    public class Credentials
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}