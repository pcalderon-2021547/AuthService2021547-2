using System.ComponentModel.DataAnnotations;

namespace AuthService2021547.Application.DTOs.Email;

public class ForgotPaswwordDto
{
    [Required]
    [EmailAddress]
    public string Email {get; set;} = string.Empty;
}