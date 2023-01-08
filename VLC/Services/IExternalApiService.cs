using System;
namespace VLC.Services
{
    public interface IExternalApiService 
    {
        public string SearchByQuery(string search_query);
        public string Next20Recipes(string next);
    }
}

