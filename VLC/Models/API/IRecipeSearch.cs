namespace VLC.Models.API
{
    public interface IRecipeSearch
    {
        object ContentType { get; set; }
        object SerializerSettings { get; set; }
        object StatusCode { get; set; }
        string Value { get; set; }
    }
}