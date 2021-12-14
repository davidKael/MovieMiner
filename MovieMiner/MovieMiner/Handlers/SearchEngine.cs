using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;



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
        

    }

}
