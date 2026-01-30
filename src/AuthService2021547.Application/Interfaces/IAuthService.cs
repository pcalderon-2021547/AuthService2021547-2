using AuthService2021547.Application.DTOs;
using AuthService2021547.Application.DTOs.Email;

namespace AuthService2021547.Application.Interface;

public interface IAuthService
{ 
 Task<RegisterResponseDto> RegisterAsync(RegistroDto registroDto);
 Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
 Task<EmailResponseDto> VerifuEmailAsync (VerifyEmailDto verifyEmailDto);
 Task<EmailResponseDto> ResendVerificationEmailAsync(ResendVerificationDto resenDto);
 Task<EmailResponseDto> ForgotPasswordAsync (ForgotPaswwordDto forgotPaswwordDto);
 Task<EmailResponseDto> ResetPasswordAsync (ResetPasswordDto resetPasswordDto);
 Task<UserResponseDto> GetUserByIdAsync(string userId);

}

