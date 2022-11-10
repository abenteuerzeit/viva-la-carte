using VLC.Data;

namespace VLC.Services
{
    public class RecipesSettings
    {
        public const string ServiceName = nameof(MealManagerService);
        public static string app_id { get; set; }
        public static string app_key { get; set; }
    }
}