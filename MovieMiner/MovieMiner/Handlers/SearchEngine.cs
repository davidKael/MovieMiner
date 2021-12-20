using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using System.Drawing;

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
        
        internal static async Task<Movie> SearchMovieById(int id)
        {
            if (Movie.All.ContainsKey(id) && Movie.All[id].GotAllInfo) 
            {
                return Movie.All[id];
            }
            else
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
                Movie movie = JsonConvert.DeserializeObject<Movie>(content);
                movie.poster_image = await LoadImage(movie);

                movie.GotAllInfo = true;
                movie.AddToDictionary();
                return movie;
            }
                
          
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


            SearchResults results = JsonConvert.DeserializeObject<SearchResults>(content);

            foreach(Movie movie in results.results)
            {
                movie.AddToDictionary();
            }
           
            return results;
        }


        internal static async Task<Image> LoadImage(Movie m)
        {
            if(!String.IsNullOrEmpty(m.poster_path))
            {
                WebRequest request = WebRequest.Create($"https://www.themoviedb.org/t/p/w1280{m.poster_path}");

                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        return Bitmap.FromStream(str);

                    }

                }
            }
            else
            {
                return null;
            }
        }
    }

}
