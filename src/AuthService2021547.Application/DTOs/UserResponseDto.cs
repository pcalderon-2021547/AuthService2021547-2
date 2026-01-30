namespace AuthService2021547.Application.DTOs;

public class UserResponseDto
{
    public String Id { get; set; } = string.Empty;
    public String Name { get; set; } = string.Empty;
    public String Surname { get; set; } = string.Empty;

    public String ProfilePicture { get; set; } = string.Empty;
    public String Phone { get; set; } = string.Empty;
    public String Role { get; set; } = string.Empty;
    public bool Status { get; set; }
    public bool IsEmailVerified { get; set; }
    public DateTime CreatedAT { get; set; }
    public DateTime UpdatedAT { get; set; }
}