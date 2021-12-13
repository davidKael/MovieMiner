using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieMiner
{
    class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime release_date { get; set; }
        public string overview { get; set; }
        public Genres[] genres { get; set; }
        public string original_language { get; set; }
        public int runtime { get; set; }
        public double vote_average { get; set; }
        public string homepage { get; set; }
        public string poster_path { get; set; }

        public class Genres
        {
            public int id { set; get; }
            public string name { set; get; }

        }

        public string[] GetAllInfo() 
        {
            List<string> output = new();

            string genresLine = "";
            foreach (Genres g in genres)
            {
                genresLine += $"{g.name} ";
            }

            output.Add($"Title: {title} ({release_date.Year})");
            output.Add($"Genre: {genresLine}");
            output.Add($"Runtime: {runtime} min");
            output.Add($"Overview: {overview}\n");
            output.Add($"Original Language: {original_language}");
            output.Add($"Rating: {vote_average * 10}%");
            output.Add($"Released: {release_date.ToShortDateString()}");
            output.Add($"HomePage: {homepage}");
            output.Add($"PosterLink: https://www.themoviedb.org/t/p/w1280{poster_path}");

            return output.ToArray();
        }
    }
}
