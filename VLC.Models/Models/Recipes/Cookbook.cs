using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public int Id { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }

        [Required]
        [Display(Name = "Cookbook Title")]
        [JsonProperty("label")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The label cannot be longer than 50 charachters")]
        public string Label { get; set; } = "My Cookbook";

        [Required]
        [JsonProperty("user")]
        public string? UserId { get; set; }

    }
}
