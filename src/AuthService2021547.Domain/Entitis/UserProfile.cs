using System.ComponentModel.DataAnnotations;

namespace AuthService2021547.Domain.Entitis;

public class UserProfile
{
    [Key]
    [MaxLength(16)]
    public string Id {get; set;} = string.Empty;

    [Required]
    [MaxLength(16)]
    public string UserId {get; set;} = string.Empty;

    [MaxLength(512)]
    public string ProfilePicture {get; set;} = string.Empty;

    [Required]
    [StringLength(8,MinimumLength = 8, ErrorMessage = "El numero de télefono debe tener 8 digítos")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "El télefono solo debe tener números.")]
    public string Phone {get; set;} = string.Empty;

    [Required]
    public User User {get; set;} = null!;
}