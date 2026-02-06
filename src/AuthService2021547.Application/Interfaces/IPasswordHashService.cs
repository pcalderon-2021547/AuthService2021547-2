namespace AuthService2021547.Application.Interfaces;

public interface IPasswordHashService
{
    string HashPassword (string password);

    bool VerifyPassword(string password, string hashedPassword);
}