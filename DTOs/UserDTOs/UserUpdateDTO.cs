using System.ComponentModel.DataAnnotations;

namespace Usuarios_API.DTOs.UserDTOs;

public record UserUpdateDTO
{
    [Required(ErrorMessage = "o nome deve ser preenchido.")]
    public string Name { get; init; }

    public string? Phone { get; init; }

    [MaxLength(50, ErrorMessage = "o tamanho máximo é 50 caracteres para web sites.")]
    public string? WebSite { get; init; }

    [Required(ErrorMessage = "o email deve ser obrigatório.")]
    [EmailAddress(ErrorMessage = "email inválido.")]
    public string Email { get; init; }

    public int? AddressId { get; init; }

    public int? CompanyId { get; init; }
}