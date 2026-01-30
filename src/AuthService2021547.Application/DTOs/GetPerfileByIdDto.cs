using System.ComponentModel.DataAnnotations;

namespace AuthService2021547.Application.DTOs;

public class GetProfileByIdDto
{
    [Required(ErrorMessage ="El UserID es requerido")]
    public string UserId {get; set;} = string.Empty;
}