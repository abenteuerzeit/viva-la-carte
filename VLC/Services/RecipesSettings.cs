using VLC.Data;

namespace VLC.Services
{
    public class RecipesSettings
    {
        public const string ServiceName = nameof(MealManagerService);
        public static string? AppId { get; set; }
        public static string? AppKey { get; set; }
    }
}