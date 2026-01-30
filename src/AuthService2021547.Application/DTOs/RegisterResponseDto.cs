namespace AuthService2021547.Application.DTOs;

public class RegisterResponseDto
{
    public bool Succes {get; set;} = false;
    public UserResponseDto User {get; set;} = new();
    public string Message {get; set; } = string.Empty;
    public bool EmailVerificationRequiered {get; set;} = true;
}