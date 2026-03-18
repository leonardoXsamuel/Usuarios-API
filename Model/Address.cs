using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Usuarios_API.model;

[Table("tb_address")]

public class Address
{
    [Key]
    public int Id { get; set; }

    [JsonPropertyName("street")]
    public string Street { get; set; }

    [JsonPropertyName("suite")]
    public string Suite { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("zipcode")]
    public string Zipcode { get; set; }

    public int? GeoId { get; set; }

    [JsonPropertyName("geo")]
    [ForeignKey(nameof(GeoId))]
    public Geo? Geo { get; set; }

    [JsonConstructor]
    public Address(string street, string suite, string city, string zipcode, Geo geo)
    {
        Street = street;
        Suite = suite;
        City = city;
        Zipcode = zipcode;
        Geo = geo;
    }

    public Address() {}

}