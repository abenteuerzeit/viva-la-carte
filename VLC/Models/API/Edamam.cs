using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace VLC.Models.API
{
    public class RecipeSearch
    {
        //{
        //    // Edamam myDeserializedClass = JsonConvert.DeserializeObject<Edamam>(myJsonResponse);

        //        public string result { get; set; } = "";
        //        public int id { get; set; }
        //        public object exception { get; set; } = "";
        //        public int status { get; set; }
        //        public bool isCanceled { get; set; }
        //        public bool isCompleted { get; set; }
        //        public bool isCompletedSuccessfully { get; set; }
        //        public int creationOptions { get; set; }
        //        public object asyncState { get; set; } = "";
        //        public bool isFaulted { get; set; }

        //}
        // RecipeSearch myDeserializedClass = JsonConvert.DeserializeObject<RecipeSearch>(myJsonResponse);
        [JsonProperty("contentType")]
        [JsonPropertyName("contentType")]
        public object ContentType { get; set; }

        [JsonProperty("serializerSettings")]
        [JsonPropertyName("serializerSettings")]
        public object SerializerSettings { get; set; }

        [JsonProperty("statusCode")]
        [JsonPropertyName("statusCode")]
        public object StatusCode { get; set; }

        [JsonProperty("value")]
        [JsonPropertyName("value")]
        public string Value { get; set; }

        public class CA
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class CHOCDF
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class CHOCDFNet
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class CHOLE
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class Digest
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("tag")]
            [JsonPropertyName("tag")]
            public string Tag { get; set; }

            [JsonProperty("schemaOrgTag")]
            [JsonPropertyName("schemaOrgTag")]
            public string SchemaOrgTag { get; set; }

            [JsonProperty("total")]
            [JsonPropertyName("total")]
            public double Total { get; set; }

            [JsonProperty("hasRDI")]
            [JsonPropertyName("hasRDI")]
            public bool HasRDI { get; set; }

            [JsonProperty("daily")]
            [JsonPropertyName("daily")]
            public double Daily { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }

            [JsonProperty("sub")]
            [JsonPropertyName("sub")]
            public List<Sub> Sub { get; } = new List<Sub>();
        }

        public class ENERCKCAL
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FAMS
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FAPU
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FASAT
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FAT
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FATRN
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FE
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FIBTG
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FOLAC
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FOLDFE
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class FOLFD
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class Hit
        {
            [JsonProperty("recipe")]
            [JsonPropertyName("recipe")]
            public Recipe Recipe { get; set; }

            [JsonProperty("_links")]
            [JsonPropertyName("_links")]
            public Links Links { get; set; }
        }

        public class Images
        {
            [JsonProperty("THUMBNAIL")]
            [JsonPropertyName("THUMBNAIL")]
            public THUMBNAIL THUMBNAIL { get; set; }

            [JsonProperty("SMALL")]
            [JsonPropertyName("SMALL")]
            public SMALL SMALL { get; set; }

            [JsonProperty("REGULAR")]
            [JsonPropertyName("REGULAR")]
            public REGULAR REGULAR { get; set; }

            [JsonProperty("LARGE")]
            [JsonPropertyName("LARGE")]
            public LARGE LARGE { get; set; }
        }

        public class Ingredient
        {
            [JsonProperty("text")]
            [JsonPropertyName("text")]
            public string Text { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("measure")]
            [JsonPropertyName("measure")]
            public string Measure { get; set; }

            [JsonProperty("food")]
            [JsonPropertyName("food")]
            public string Food { get; set; }

            [JsonProperty("weight")]
            [JsonPropertyName("weight")]
            public double Weight { get; set; }

            [JsonProperty("foodCategory")]
            [JsonPropertyName("foodCategory")]
            public string FoodCategory { get; set; }

            [JsonProperty("foodId")]
            [JsonPropertyName("foodId")]
            public string FoodId { get; set; }

            [JsonProperty("image")]
            [JsonPropertyName("image")]
            public string Image { get; set; }
        }

        public class K
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class LARGE
        {
            [JsonProperty("url")]
            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            [JsonPropertyName("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            [JsonPropertyName("height")]
            public int Height { get; set; }
        }

        public class Links
        {
            [JsonProperty("next")]
            [JsonPropertyName("next")]
            public Next Next { get; set; }

            [JsonProperty("self")]
            [JsonPropertyName("self")]
            public Self Self { get; set; }
        }

        public class MG
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class NA
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class Next
        {
            [JsonProperty("href")]
            [JsonPropertyName("href")]
            public string Href { get; set; }

            [JsonProperty("title")]
            [JsonPropertyName("title")]
            public string Title { get; set; }
        }

        public class NIA
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class P
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class PROCNT
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class Recipe
        {
            [JsonProperty("uri")]
            [JsonPropertyName("uri")]
            public string Uri { get; set; }

            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("image")]
            [JsonPropertyName("image")]
            public string Image { get; set; }

            [JsonProperty("images")]
            [JsonPropertyName("images")]
            public Images Images { get; set; }

            [JsonProperty("source")]
            [JsonPropertyName("source")]
            public string Source { get; set; }

            [JsonProperty("url")]
            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonProperty("shareAs")]
            [JsonPropertyName("shareAs")]
            public string ShareAs { get; set; }

            [JsonProperty("yield")]
            [JsonPropertyName("yield")]
            public double Yield { get; set; }

            [JsonProperty("dietLabels")]
            [JsonPropertyName("dietLabels")]
            public List<string> DietLabels { get; } = new List<string>();

            [JsonProperty("healthLabels")]
            [JsonPropertyName("healthLabels")]
            public List<string> HealthLabels { get; } = new List<string>();

            [JsonProperty("cautions")]
            [JsonPropertyName("cautions")]
            public List<string> Cautions { get; } = new List<string>();

            [JsonProperty("ingredientLines")]
            [JsonPropertyName("ingredientLines")]
            public List<string> IngredientLines { get; } = new List<string>();

            [JsonProperty("ingredients")]
            [JsonPropertyName("ingredients")]
            public List<Ingredient> Ingredients { get; } = new List<Ingredient>();

            [JsonProperty("calories")]
            [JsonPropertyName("calories")]
            public double Calories { get; set; }

            [JsonProperty("totalWeight")]
            [JsonPropertyName("totalWeight")]
            public double TotalWeight { get; set; }

            [JsonProperty("totalTime")]
            [JsonPropertyName("totalTime")]
            public double TotalTime { get; set; }

            [JsonProperty("cuisineType")]
            [JsonPropertyName("cuisineType")]
            public List<string> CuisineType { get; } = new List<string>();

            [JsonProperty("mealType")]
            [JsonPropertyName("mealType")]
            public List<string> MealType { get; } = new List<string>();

            [JsonProperty("dishType")]
            [JsonPropertyName("dishType")]
            public List<string> DishType { get; } = new List<string>();

            [JsonProperty("totalNutrients")]
            [JsonPropertyName("totalNutrients")]
            public TotalNutrients TotalNutrients { get; set; }

            [JsonProperty("totalDaily")]
            [JsonPropertyName("totalDaily")]
            public TotalDaily TotalDaily { get; set; }

            [JsonProperty("digest")]
            [JsonPropertyName("digest")]
            public List<Digest> Digest { get; } = new List<Digest>();
        }

        public class REGULAR
        {
            [JsonProperty("url")]
            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            [JsonPropertyName("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            [JsonPropertyName("height")]
            public int Height { get; set; }
        }

        public class RIBF
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class Root
        {
            [JsonProperty("from")]
            [JsonPropertyName("from")]
            public int From { get; set; }

            [JsonProperty("to")]
            [JsonPropertyName("to")]
            public int To { get; set; }

            [JsonProperty("count")]
            [JsonPropertyName("count")]
            public int Count { get; set; }

            [JsonProperty("_links")]
            [JsonPropertyName("_links")]
            public Links Links { get; set; }

            [JsonProperty("hits")]
            [JsonPropertyName("hits")]
            public List<Hit> Hits { get; } = new List<Hit>();
        }

        public class Self
        {
            [JsonProperty("href")]
            [JsonPropertyName("href")]
            public string Href { get; set; }

            [JsonProperty("title")]
            [JsonPropertyName("title")]
            public string Title { get; set; }
        }

        public class SMALL
        {
            [JsonProperty("url")]
            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            [JsonPropertyName("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            [JsonPropertyName("height")]
            public int Height { get; set; }
        }

        public class Sub
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("tag")]
            [JsonPropertyName("tag")]
            public string Tag { get; set; }

            [JsonProperty("schemaOrgTag")]
            [JsonPropertyName("schemaOrgTag")]
            public string SchemaOrgTag { get; set; }

            [JsonProperty("total")]
            [JsonPropertyName("total")]
            public double Total { get; set; }

            [JsonProperty("hasRDI")]
            [JsonPropertyName("hasRDI")]
            public bool HasRDI { get; set; }

            [JsonProperty("daily")]
            [JsonPropertyName("daily")]
            public double Daily { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class SUGAR
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class SUGARAdded
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class SugarAlcohol
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class THIA
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class THUMBNAIL
        {
            [JsonProperty("url")]
            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            [JsonPropertyName("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            [JsonPropertyName("height")]
            public int Height { get; set; }
        }

        public class TOCPHA
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class TotalDaily
        {
            [JsonProperty("ENERC_KCAL")]
            [JsonPropertyName("ENERC_KCAL")]
            public ENERCKCAL ENERCKCAL { get; set; }

            [JsonProperty("FAT")]
            [JsonPropertyName("FAT")]
            public FAT FAT { get; set; }

            [JsonProperty("FASAT")]
            [JsonPropertyName("FASAT")]
            public FASAT FASAT { get; set; }

            [JsonProperty("CHOCDF")]
            [JsonPropertyName("CHOCDF")]
            public CHOCDF CHOCDF { get; set; }

            [JsonProperty("FIBTG")]
            [JsonPropertyName("FIBTG")]
            public FIBTG FIBTG { get; set; }

            [JsonProperty("PROCNT")]
            [JsonPropertyName("PROCNT")]
            public PROCNT PROCNT { get; set; }

            [JsonProperty("CHOLE")]
            [JsonPropertyName("CHOLE")]
            public CHOLE CHOLE { get; set; }

            [JsonProperty("NA")]
            [JsonPropertyName("NA")]
            public NA NA { get; set; }

            [JsonProperty("CA")]
            [JsonPropertyName("CA")]
            public CA CA { get; set; }

            [JsonProperty("MG")]
            [JsonPropertyName("MG")]
            public MG MG { get; set; }

            [JsonProperty("K")]
            [JsonPropertyName("K")]
            public K K { get; set; }

            [JsonProperty("FE")]
            [JsonPropertyName("FE")]
            public FE FE { get; set; }

            [JsonProperty("ZN")]
            [JsonPropertyName("ZN")]
            public ZN ZN { get; set; }

            [JsonProperty("P")]
            [JsonPropertyName("P")]
            public P P { get; set; }

            [JsonProperty("VITA_RAE")]
            [JsonPropertyName("VITA_RAE")]
            public VITARAE VITARAE { get; set; }

            [JsonProperty("VITC")]
            [JsonPropertyName("VITC")]
            public VITC VITC { get; set; }

            [JsonProperty("THIA")]
            [JsonPropertyName("THIA")]
            public THIA THIA { get; set; }

            [JsonProperty("RIBF")]
            [JsonPropertyName("RIBF")]
            public RIBF RIBF { get; set; }

            [JsonProperty("NIA")]
            [JsonPropertyName("NIA")]
            public NIA NIA { get; set; }

            [JsonProperty("VITB6A")]
            [JsonPropertyName("VITB6A")]
            public VITB6A VITB6A { get; set; }

            [JsonProperty("FOLDFE")]
            [JsonPropertyName("FOLDFE")]
            public FOLDFE FOLDFE { get; set; }

            [JsonProperty("VITB12")]
            [JsonPropertyName("VITB12")]
            public VITB12 VITB12 { get; set; }

            [JsonProperty("VITD")]
            [JsonPropertyName("VITD")]
            public VITD VITD { get; set; }

            [JsonProperty("TOCPHA")]
            [JsonPropertyName("TOCPHA")]
            public TOCPHA TOCPHA { get; set; }

            [JsonProperty("VITK1")]
            [JsonPropertyName("VITK1")]
            public VITK1 VITK1 { get; set; }
        }

        public class TotalNutrients
        {
            [JsonProperty("ENERC_KCAL")]
            [JsonPropertyName("ENERC_KCAL")]
            public ENERCKCAL ENERCKCAL { get; set; }

            [JsonProperty("FAT")]
            [JsonPropertyName("FAT")]
            public FAT FAT { get; set; }

            [JsonProperty("FASAT")]
            [JsonPropertyName("FASAT")]
            public FASAT FASAT { get; set; }

            [JsonProperty("FATRN")]
            [JsonPropertyName("FATRN")]
            public FATRN FATRN { get; set; }

            [JsonProperty("FAMS")]
            [JsonPropertyName("FAMS")]
            public FAMS FAMS { get; set; }

            [JsonProperty("FAPU")]
            [JsonPropertyName("FAPU")]
            public FAPU FAPU { get; set; }

            [JsonProperty("CHOCDF")]
            [JsonPropertyName("CHOCDF")]
            public CHOCDF CHOCDF { get; set; }

            [JsonProperty("CHOCDF.net")]
            [JsonPropertyName("CHOCDF.net")]
            public CHOCDFNet CHOCDFNet { get; set; }

            [JsonProperty("FIBTG")]
            [JsonPropertyName("FIBTG")]
            public FIBTG FIBTG { get; set; }

            [JsonProperty("SUGAR")]
            [JsonPropertyName("SUGAR")]
            public SUGAR SUGAR { get; set; }

            [JsonProperty("SUGAR.added")]
            [JsonPropertyName("SUGAR.added")]
            public SUGARAdded SUGARAdded { get; set; }

            [JsonProperty("PROCNT")]
            [JsonPropertyName("PROCNT")]
            public PROCNT PROCNT { get; set; }

            [JsonProperty("CHOLE")]
            [JsonPropertyName("CHOLE")]
            public CHOLE CHOLE { get; set; }

            [JsonProperty("NA")]
            [JsonPropertyName("NA")]
            public NA NA { get; set; }

            [JsonProperty("CA")]
            [JsonPropertyName("CA")]
            public CA CA { get; set; }

            [JsonProperty("MG")]
            [JsonPropertyName("MG")]
            public MG MG { get; set; }

            [JsonProperty("K")]
            [JsonPropertyName("K")]
            public K K { get; set; }

            [JsonProperty("FE")]
            [JsonPropertyName("FE")]
            public FE FE { get; set; }

            [JsonProperty("ZN")]
            [JsonPropertyName("ZN")]
            public ZN ZN { get; set; }

            [JsonProperty("P")]
            [JsonPropertyName("P")]
            public P P { get; set; }

            [JsonProperty("VITA_RAE")]
            [JsonPropertyName("VITA_RAE")]
            public VITARAE VITARAE { get; set; }

            [JsonProperty("VITC")]
            [JsonPropertyName("VITC")]
            public VITC VITC { get; set; }

            [JsonProperty("THIA")]
            [JsonPropertyName("THIA")]
            public THIA THIA { get; set; }

            [JsonProperty("RIBF")]
            [JsonPropertyName("RIBF")]
            public RIBF RIBF { get; set; }

            [JsonProperty("NIA")]
            [JsonPropertyName("NIA")]
            public NIA NIA { get; set; }

            [JsonProperty("VITB6A")]
            [JsonPropertyName("VITB6A")]
            public VITB6A VITB6A { get; set; }

            [JsonProperty("FOLDFE")]
            [JsonPropertyName("FOLDFE")]
            public FOLDFE FOLDFE { get; set; }

            [JsonProperty("FOLFD")]
            [JsonPropertyName("FOLFD")]
            public FOLFD FOLFD { get; set; }

            [JsonProperty("FOLAC")]
            [JsonPropertyName("FOLAC")]
            public FOLAC FOLAC { get; set; }

            [JsonProperty("VITB12")]
            [JsonPropertyName("VITB12")]
            public VITB12 VITB12 { get; set; }

            [JsonProperty("VITD")]
            [JsonPropertyName("VITD")]
            public VITD VITD { get; set; }

            [JsonProperty("TOCPHA")]
            [JsonPropertyName("TOCPHA")]
            public TOCPHA TOCPHA { get; set; }

            [JsonProperty("VITK1")]
            [JsonPropertyName("VITK1")]
            public VITK1 VITK1 { get; set; }

            [JsonProperty("Sugar.alcohol")]
            [JsonPropertyName("Sugar.alcohol")]
            public SugarAlcohol SugarAlcohol { get; set; }

            [JsonProperty("WATER")]
            [JsonPropertyName("WATER")]
            public WATER WATER { get; set; }
        }

        public class VITARAE
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class VITB12
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class VITB6A
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class VITC
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class VITD
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class VITK1
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class WATER
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }

        public class ZN
        {
            [JsonProperty("label")]
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonProperty("quantity")]
            [JsonPropertyName("quantity")]
            public double Quantity { get; set; }

            [JsonProperty("unit")]
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
        }


    }
}

