using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Usuarios_API.model
{
    public class Geo
    {
        [JsonPropertyName("lat")]
        public string? Lat { get; set; }
        [JsonPropertyName("lng")]
        public string? Lng { get; set; }    

        [JsonConstructor]
        public Geo(string lat, string lng)
        {
            Lat = lat;  
            Lng = lng;
        }
    }
}