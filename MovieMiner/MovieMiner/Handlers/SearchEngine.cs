using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

namespace MovieMiner
{
    static class SearchEngine
    {
        private static HttpClient client = new HttpClient();
        private static string url = "https://api.themoviedb.org/";
        private static string key;




        internal static void GetKey()
        {
            DotNetEnv.Env.TraversePath().Load();
            key = Environment.GetEnvironmentVariable("API_KEY");
        }
        
        internal static async Task<Movie> SearchMovieById(string id)
        {
            string uri = $@"{url}3/movie/{id}?api_key={key}";
            var response = await client.GetAsync(uri);

            try 
            { 
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                return null;
                //did not work
            }

            var content = await response.Content.ReadAsStringAsync();
          
            return JsonConvert.DeserializeObject<Movie>(content);
        }
        
        internal static async Task<SearchResults> SearchMoviesByTitle(string input)
        {
            string uri = $@"{url}3/search/movie?api_key={key}&language=en-US&query={input}&page=1&include_adult=false";
            var response = await client.GetAsync(uri);

            try
            {
               response.EnsureSuccessStatusCode();
            }
            catch
            {
                return null;
                //did not work
            }

            var content = await response.Content.ReadAsStringAsync();

            SearchResults searchResult = JsonConvert.DeserializeObject<SearchResults>(content);
            return searchResult;
        }


    }

}
