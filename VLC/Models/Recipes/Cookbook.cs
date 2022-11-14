using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace VLC.Models.Recipes
{
    public class Cookbook
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Required]
        [JsonProperty("recipes")]
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        [JsonProperty("label")]
        public string Label { get; set; } = "My Cookbook";

    }
}
