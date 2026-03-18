using System.ComponentModel.DataAnnotations;

namespace Usuarios_API.DTOs.UserDTOs;

public record UserCreateDTO
{
    [Required(ErrorMessage = "o nome deve ser preenchido.")]
    public required string Name { get; init; }

    public string? Phone { get; init; }

    public string? WebSite { get; init; }

    [EmailAddress(ErrorMessage = "email inválido.")]
    public string? Email { get; init; }

    public int? AddressId { get; init; }

    public int? CompanyId { get; init; }
}