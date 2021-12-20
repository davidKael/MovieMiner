using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieMiner
{
    internal static class SearchEngine
    {
        private static HttpClient client = new HttpClient();
        private static string url = "https://api.themoviedb.org/";
        private static string key;

        public static bool TryKey(string newKey)
        {
            if (!string.IsNullOrEmpty(newKey) || !string.IsNullOrWhiteSpace(newKey))
            {
                key = newKey;
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool GetKey()
        {
            DotNetEnv.Env.TraversePath().Load();
            key = Environment.GetEnvironmentVariable("API_KEY");

            return key != null;
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

        internal static async Task<SearchResults> SearchMoviesByTitle(string input, int page)
        {
            SearchResults.CurrSearchWord = input;

            string uri = $@"{url}3/search/movie?api_key={key}&language=en-US&query={input}&page={page}&include_adult=false";
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

            foreach (Movie movie in results.results)
            {
                movie.AddToDictionary();
            }

            SearchResults.CurrPage = page;
            return results;
        }

        internal static async Task<Image> LoadImage(Movie m)
        {
            if (!String.IsNullOrEmpty(m.poster_path))
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