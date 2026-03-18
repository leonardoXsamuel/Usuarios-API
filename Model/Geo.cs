using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Usuarios_API.model
{
    [Table("tb_geo")]
    public class Geo
    {
        [Key]
        public int Id { get; set; }

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

        public Geo(){}
    }
}