using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Usuarios_API.model
{
    public class Usuario
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set;  }

        [JsonPropertyName("email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("website")]
        public string WebSite { get; set; }

        [JsonPropertyName("company")]
        public Company Company { get; set; }

        [JsonConstructor]
        public Usuario(int id, string name, string email, Address address, string phone, string website, Company company)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Phone = phone;
            WebSite = website;
            Company = company;
        }


    }
}
