﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using VLC.Models.Recipes;
//
//    var hits = Hits.FromJson(jsonString);

namespace VLC.Models.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Hits
    {
        [Key]
        public int Id { get; set; }
        [JsonProperty("from")]
        public long From { get; set; }

        [JsonProperty("to")]
        public long To { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("_links")]
        public HitsLinks Links { get; set; }

        [JsonProperty("hits")]
        public List<Hit> HitsList { get; set; } = new List<Hit>();
    }

    public partial class Hit
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("recipe")]
        public Recipe Recipe { get; set; }

        [JsonProperty("_links")]
        public HitLinks Links { get; set; }
    }

    public partial class HitLinks
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("self")]
        public Next Self { get; set; }
    }

    public partial class Next
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("title")]
        public Title Title { get; set; }
    }

    public partial class Recipe
    {
        //public int Id { get; set; }

        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("shareAs")]
        public Uri ShareAs { get; set; }

        [JsonProperty("yield")]
        public long Yield { get; set; }

        [JsonProperty("dietLabels")]
        [NotMapped]
        public List<DietLabel> DietLabels { get; set; }

        [JsonProperty("healthLabels")]
        [NotMapped]
        public List<string> HealthLabels { get; set; }

        [JsonProperty("cautions")]
        [NotMapped]
        public List<string> Cautions { get; set; }

        [JsonProperty("ingredientLines")]
        [NotMapped]
        public List<string> IngredientLines { get; set; }

        [JsonProperty("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("calories")]
        public double Calories { get; set; }

        [JsonProperty("totalWeight")]
        public double TotalWeight { get; set; }

        [JsonProperty("totalTime")]
        public long TotalTime { get; set; }

        [JsonProperty("cuisineType")]
        [NotMapped]
        public List<string> CuisineType { get; set; }

        [JsonProperty("mealType")]
        [NotMapped]
        public List<MealType> MealType { get; set; }

        [JsonProperty("dishType")]
        [NotMapped]
        public List<DishType> DishType { get; set; }

        [JsonProperty("totalNutrients")]
        [NotMapped]
        public Dictionary<string, Total> TotalNutrients { get; set; }

        [JsonProperty("totalDaily")]
        [NotMapped]
        public Dictionary<string, Total> TotalDaily { get; set; }

        [JsonProperty("digest")]
        [NotMapped]
        public List<Digest> Digest { get; set; }
    }

    public partial class Digest
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("schemaOrgTag")]
        public SchemaOrgTag? SchemaOrgTag { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("hasRDI")]
        public bool HasRdi { get; set; }

        [JsonProperty("daily")]
        public double Daily { get; set; }

        [JsonProperty("unit")]
        public Unit Unit { get; set; }

        [JsonProperty("sub", NullValueHandling = NullValueHandling.Ignore)]
        public Digest[] Sub { get; set; }
    }

    public partial class Images
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("THUMBNAIL")]
        public Large Thumbnail { get; set; }

        [JsonProperty("SMALL")]
        public Large Small { get; set; }

        [JsonProperty("REGULAR")]
        public Large Regular { get; set; }

        [JsonProperty("LARGE", NullValueHandling = NullValueHandling.Ignore)]
        public Large Large { get; set; }
    }

    public partial class Large
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class Ingredient
    {
        //public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }

        [JsonProperty("food")]
        public string Food { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("foodCategory")]
        public string FoodCategory { get; set; }

        [JsonProperty("foodId")]
        public string FoodId { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }
    }

    public partial class Total
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public Unit Unit { get; set; }
    }

    public partial class HitsLinks
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("next")]
        public Next Next { get; set; }
    }


    // TODO: Complete enums
    public enum Title { NextPage, Self };

    public enum Caution { Eggs, Fodmap, Milk, Soy, Sulfites };

    public enum CuisineType { Greek, Italian };

    public enum DietLabel { Balanced, HighFiber, LowCarb, LowSodium };

    public enum SchemaOrgTag { CarbohydrateContent, CholesterolContent, FatContent, FiberContent, ProteinContent, SaturatedFatContent, SodiumContent, SugarContent, TransFatContent };

    public enum Unit { Empty, G, Kcal, Mg, Μg };

    public enum DishType { MainCourse, Salad, Starter };

    public enum MealType { Breakfast, Brunch, LunchDinner };

    public partial class Hits
    {
        public static Hits FromJson(string json) => JsonConvert.DeserializeObject<Hits>(json, VLC.Models.Recipes.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Hits self) => JsonConvert.SerializeObject(self, VLC.Models.Recipes.Converter.Settings);
    }


    // TODO: Build this class to service all enums 
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TitleConverter.Singleton,
                CautionConverter.Singleton,
                CuisineTypeConverter.Singleton,
                DietLabelConverter.Singleton,
                SchemaOrgTagConverter.Singleton,
                UnitConverter.Singleton,
                DishTypeConverter.Singleton,
                MealTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Title) || t == typeof(Title?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Next page":
                    return Title.NextPage;
                case "Self":
                    return Title.Self;
            }
            throw new Exception("Cannot unmarshal type Title");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Title)untypedValue;
            switch (value)
            {
                case Title.NextPage:
                    serializer.Serialize(writer, "Next page");
                    return;
                case Title.Self:
                    serializer.Serialize(writer, "Self");
                    return;
            }
            throw new Exception("Cannot marshal type Title");
        }

        public static readonly TitleConverter Singleton = new TitleConverter();
    }

    internal class CautionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Caution) || t == typeof(Caution?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Eggs":
                    return Caution.Eggs;
                case "FODMAP":
                    return Caution.Fodmap;
                case "Milk":
                    return Caution.Milk;
                case "Soy":
                    return Caution.Soy;
                case "Sulfites":
                    return Caution.Sulfites;
            }
            throw new Exception("Cannot unmarshal type Caution");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Caution)untypedValue;
            switch (value)
            {
                case Caution.Eggs:
                    serializer.Serialize(writer, "Eggs");
                    return;
                case Caution.Fodmap:
                    serializer.Serialize(writer, "FODMAP");
                    return;
                case Caution.Milk:
                    serializer.Serialize(writer, "Milk");
                    return;
                case Caution.Soy:
                    serializer.Serialize(writer, "Soy");
                    return;
                case Caution.Sulfites:
                    serializer.Serialize(writer, "Sulfites");
                    return;
            }
            throw new Exception("Cannot marshal type Caution");
        }

        public static readonly CautionConverter Singleton = new CautionConverter();
    }

    internal class CuisineTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CuisineType) || t == typeof(CuisineType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "greek":
                    return CuisineType.Greek;
                case "italian":
                    return CuisineType.Italian;
            }
            throw new Exception("Cannot unmarshal type CuisineType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CuisineType)untypedValue;
            switch (value)
            {
                case CuisineType.Greek:
                    serializer.Serialize(writer, "greek");
                    return;
                case CuisineType.Italian:
                    serializer.Serialize(writer, "italian");
                    return;
            }
            throw new Exception("Cannot marshal type CuisineType");
        }

        public static readonly CuisineTypeConverter Singleton = new CuisineTypeConverter();
    }

    internal class DietLabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DietLabel) || t == typeof(DietLabel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Balanced":
                    return DietLabel.Balanced;
                case "High-Fiber":
                    return DietLabel.HighFiber;
                case "Low-Carb":
                    return DietLabel.LowCarb;
                case "Low-Sodium":
                    return DietLabel.LowSodium;
            }
            throw new Exception("Cannot unmarshal type DietLabel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DietLabel)untypedValue;
            switch (value)
            {
                case DietLabel.Balanced:
                    serializer.Serialize(writer, "Balanced");
                    return;
                case DietLabel.HighFiber:
                    serializer.Serialize(writer, "High-Fiber");
                    return;
                case DietLabel.LowCarb:
                    serializer.Serialize(writer, "Low-Carb");
                    return;
                case DietLabel.LowSodium:
                    serializer.Serialize(writer, "Low-Sodium");
                    return;
            }
            throw new Exception("Cannot marshal type DietLabel");
        }

        public static readonly DietLabelConverter Singleton = new DietLabelConverter();
    }

    internal class SchemaOrgTagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SchemaOrgTag) || t == typeof(SchemaOrgTag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "carbohydrateContent":
                    return SchemaOrgTag.CarbohydrateContent;
                case "cholesterolContent":
                    return SchemaOrgTag.CholesterolContent;
                case "fatContent":
                    return SchemaOrgTag.FatContent;
                case "fiberContent":
                    return SchemaOrgTag.FiberContent;
                case "proteinContent":
                    return SchemaOrgTag.ProteinContent;
                case "saturatedFatContent":
                    return SchemaOrgTag.SaturatedFatContent;
                case "sodiumContent":
                    return SchemaOrgTag.SodiumContent;
                case "sugarContent":
                    return SchemaOrgTag.SugarContent;
                case "transFatContent":
                    return SchemaOrgTag.TransFatContent;
            }
            throw new Exception("Cannot unmarshal type SchemaOrgTag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SchemaOrgTag)untypedValue;
            switch (value)
            {
                case SchemaOrgTag.CarbohydrateContent:
                    serializer.Serialize(writer, "carbohydrateContent");
                    return;
                case SchemaOrgTag.CholesterolContent:
                    serializer.Serialize(writer, "cholesterolContent");
                    return;
                case SchemaOrgTag.FatContent:
                    serializer.Serialize(writer, "fatContent");
                    return;
                case SchemaOrgTag.FiberContent:
                    serializer.Serialize(writer, "fiberContent");
                    return;
                case SchemaOrgTag.ProteinContent:
                    serializer.Serialize(writer, "proteinContent");
                    return;
                case SchemaOrgTag.SaturatedFatContent:
                    serializer.Serialize(writer, "saturatedFatContent");
                    return;
                case SchemaOrgTag.SodiumContent:
                    serializer.Serialize(writer, "sodiumContent");
                    return;
                case SchemaOrgTag.SugarContent:
                    serializer.Serialize(writer, "sugarContent");
                    return;
                case SchemaOrgTag.TransFatContent:
                    serializer.Serialize(writer, "transFatContent");
                    return;
            }
            throw new Exception("Cannot marshal type SchemaOrgTag");
        }

        public static readonly SchemaOrgTagConverter Singleton = new SchemaOrgTagConverter();
    }

    internal class UnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Unit) || t == typeof(Unit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "%":
                    return Unit.Empty;
                case "g":
                    return Unit.G;
                case "kcal":
                    return Unit.Kcal;
                case "mg":
                    return Unit.Mg;
                case "µg":
                    return Unit.Μg;
            }
            throw new Exception("Cannot unmarshal type Unit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Unit)untypedValue;
            switch (value)
            {
                case Unit.Empty:
                    serializer.Serialize(writer, "%");
                    return;
                case Unit.G:
                    serializer.Serialize(writer, "g");
                    return;
                case Unit.Kcal:
                    serializer.Serialize(writer, "kcal");
                    return;
                case Unit.Mg:
                    serializer.Serialize(writer, "mg");
                    return;
                case Unit.Μg:
                    serializer.Serialize(writer, "µg");
                    return;
            }
            throw new Exception("Cannot marshal type Unit");
        }

        public static readonly UnitConverter Singleton = new UnitConverter();
    }

    internal class DishTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DishType) || t == typeof(DishType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "main course":
                    return DishType.MainCourse;
                case "salad":
                    return DishType.Salad;
                case "starter":
                    return DishType.Starter;
            }
            throw new Exception("Cannot unmarshal type DishType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DishType)untypedValue;
            switch (value)
            {
                case DishType.MainCourse:
                    serializer.Serialize(writer, "main course");
                    return;
                case DishType.Salad:
                    serializer.Serialize(writer, "salad");
                    return;
                case DishType.Starter:
                    serializer.Serialize(writer, "starter");
                    return;
            }
            throw new Exception("Cannot marshal type DishType");
        }

        public static readonly DishTypeConverter Singleton = new DishTypeConverter();
    }

    internal class MealTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MealType) || t == typeof(MealType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "breakfast":
                    return MealType.Breakfast;
                case "brunch":
                    return MealType.Brunch;
                case "lunch/dinner":
                    return MealType.LunchDinner;
            }
            throw new Exception("Cannot unmarshal type MealType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MealType)untypedValue;
            switch (value)
            {
                case MealType.Breakfast:
                    serializer.Serialize(writer, "breakfast");
                    return;
                case MealType.Brunch:
                    serializer.Serialize(writer, "brunch");
                    return;
                case MealType.LunchDinner:
                    serializer.Serialize(writer, "lunch/dinner");
                    return;
            }
            throw new Exception("Cannot marshal type MealType");
        }

        public static readonly MealTypeConverter Singleton = new MealTypeConverter();
    }
}