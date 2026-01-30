namespace AuthService2021547.Application.DTOs.Email;

public class EmailResponseDto
{
    
    public bool Succes {get; set;}
    public string Message {get; set;} = string.Empty;

    public object? Data {get; set;}
}