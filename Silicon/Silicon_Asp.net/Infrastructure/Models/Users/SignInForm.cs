using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models.Users;

public class SignInForm
{
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "A valid email address is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "A valid password is required")]
    [MinLength(8, ErrorMessage = "A valid password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Remeber me")]
    public bool RememberMe { get; set; }
}
