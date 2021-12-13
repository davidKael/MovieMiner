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
        private static string url = "https://www.themoviedb.org/";
        private static string key;




        internal static void GetKey()
        {
            DotNetEnv.Env.TraversePath().Load();
            key = Environment.GetEnvironmentVariable("API_KEY");
        }
        


    }

}
