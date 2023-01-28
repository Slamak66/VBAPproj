using System.ComponentModel.DataAnnotations;

namespace VBAPproj.Data.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email is required.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
