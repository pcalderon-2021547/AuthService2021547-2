using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AuthService2021547.Domain.Entitis;

public class UserEmail
{
    [Key]
    [MaxLength(16)]
    public string Id {get; set; } = string.Empty;

    [Required]
    [MaxLength(16)]
    public string UserId {get; set; } =string.Empty;

    public bool EmailVerified {get; set; } = false;

    [MaxLength(256)]
    public string? EmailVerificationToken {get; set; }

    public DateTime? EmailVerificationTokenExpiry {get; set;}

    public User User {get; set; } = null!;

}