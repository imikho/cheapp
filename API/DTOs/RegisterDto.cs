using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [MaxLength(32)]
    [Required]
    public required string Username {get; set;}

    [Required]
    public required string Password {get; set;}
}
