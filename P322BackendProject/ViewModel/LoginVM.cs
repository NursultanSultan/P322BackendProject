using System.ComponentModel.DataAnnotations;

namespace PustokP322.ViewModel
{
    public class LoginVM
    {
        [Required, MaxLength(50), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(50), DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
