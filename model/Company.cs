using System.Text.Json.Serialization;

namespace Usuarios_API.model
{
    
    public class Company
    {
        [JsonPropertyName("name")]
        public string CompanyName { get; set; }

        public Company(string companyName)
        {
            CompanyName = companyName;
        }

    }
}