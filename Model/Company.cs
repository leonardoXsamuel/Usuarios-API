using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Usuarios_API.model;

[Table("tb_company")]
public class Company
{

    [Key]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string CompanyName { get; set; }

    public Company(string companyName)
    {
        CompanyName = companyName;
    }

    public Company() { }
}