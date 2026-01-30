namespace AuthService2021547.Application.Interface;

public interface IEmailService
{
    Task sendEmailVerificationAsync (string emial, string username, string token);
    Task SendPasswordResetAsync(string email, string username, string token);
    Task SendWelcomeEmialAsync(string email, string username);
}