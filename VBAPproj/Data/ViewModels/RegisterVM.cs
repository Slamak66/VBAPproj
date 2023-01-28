using System.ComponentModel.DataAnnotations;

namespace VBAPproj.Data.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Full name is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Confirm is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
