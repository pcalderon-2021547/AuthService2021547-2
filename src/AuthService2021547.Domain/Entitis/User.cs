using System.ComponentModel.DataAnnotations;

namespace AuthService2021547.Domain.Entitis;

public class User
{
    [Key]
    [MaxLength(16)]
    public string Id {get; set;} = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [MaxLength(25, ErrorMessage ="El nombre no puede tener más de 25 carácteres.")]
    public string Name {get; set; } = string.Empty;

    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [MaxLength(25, ErrorMessage ="El apellido no puede tener más de 25 carácteres.")]
    public string Surname {get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    [MaxLength(25, ErrorMessage ="El nombre de usuario no puede tener más de 25 carácteres.")]
    public string Username {get; set; } = string.Empty;

    [Required(ErrorMessage ="El correo es obligatorio")]
    [EmailAddress(ErrorMessage ="El correo no tiene formato válido")]
    [MaxLength(150, ErrorMessage ="El correo no puede tener mas de 150 caracteres")]
    public string Email {get; set; } = string.Empty;

    [Required(ErrorMessage ="La contraseña es obligatoria")]
    [MinLength(8,ErrorMessage ="La contraseña debe tener almenos 8 caracteres")]
    [MaxLength(255, ErrorMessage ="La contraseña no puede tener  mas de 355 caracteres")]
    public string Password {get; set; } = string.Empty;

    public bool  Status {get; set; } = false;

    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}

    public UserProfile UserProfile {get; set; } = null!;

    public ICollection<UserRole> UserRoles{get; set;} = null!;

    public UserEmail UserEmail {get; set;} = null!;

    public UserPasswordReset UserPasswordReset {get; set;} = null!;
}