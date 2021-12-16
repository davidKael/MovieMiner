using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMiner
{
    class Movie
    {
        public bool adult { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string release_date { get; set; }
        public string overview { get; set; }
        public string original_language { get; set; }
        public double vote_average { get; set; }
        public string poster_path { get; set; }


        public Genres[] genres { get; set; }

        public int? runtime { get; set; }

        public string homepage { get; set; }


        public class Genres
        {
            public int id { set; get; }
            public string name { set; get; }

        }

        public virtual string[] GetAllInfo()
        {
            List<string> output = new();

            output.Add($"{title} ({Convert.ToDateTime(release_date).Year})");
            output.Add($"{overview}\n");
            output.Add($"Original Language: {original_language}");
            output.Add($"Rating: {vote_average * 10}%");
            output.Add($"Released: {release_date}");
            output.Add($"PosterLink: https://www.themoviedb.org/t/p/w1280{poster_path}");

            return output.ToArray();
        }

        
    }
}
