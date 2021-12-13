using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieMiner.SearchItems
{
    class Movie
    {
        public int ID { get; set; }
        public string PageUrl { get; set; }
        public string PosterUrl { get; set; }
        public string Title { get; set; }
        public string[] AltTitles { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string[] Genres { get; set; }
        public double Raiting { get; set; }
        public string OriginalLanguage { get; set; }
    }
}
