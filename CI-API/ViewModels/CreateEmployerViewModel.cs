using System.ComponentModel.DataAnnotations;

namespace CI_API.ViewModels
{
    public class CreateEmployerViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}