using System;
namespace VLC.Services
{
    public interface IExternalApiService 
    {
        public string SearchByQuery(string search_query);
    }
}

