using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Usuarios_API.model;

namespace Usuarios_API.Model;

[Table("tb_users")]
public class User
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "o nome deve ser preenchido.")]
    public string Name { get; set; }

    public string? Phone { get; set; }

    [MaxLength(50, ErrorMessage = "o tamanho máximo é 50 caracteres para web sites.")]
    public string WebSite { get; set; }

    [EmailAddress(ErrorMessage = "o email deve ser obrigatório.")]
    public string Email { get; set; }
    public int? AddressId { get; set; }

    [ForeignKey(nameof(AddressId))]
    public Address? Address { get; set; }
    public int? CompanyId { get; set; }

    [ForeignKey(nameof(CompanyId))]
    public Company? Company { get; set; }
    
    public User (int id, string name, string phone, string webSite, string email, Address address, Company company)
    {
        Id = id;
        Name = name;
        Phone = phone;
        WebSite = webSite;
        Email = email;
        Address = address;
        Company = company;
    }

    public User() {}

}
