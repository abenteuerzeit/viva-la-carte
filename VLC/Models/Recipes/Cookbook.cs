using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VLC.Models.Recipes
{
    public class Cookbook
    {
        [Key]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonProperty("recipes")]
        [JsonPropertyName("recipes")]
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; set; } = "My Cookbook";

    }
}
