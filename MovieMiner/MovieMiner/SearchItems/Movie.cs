using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MovieMiner
{
    class Movie
    {
        public static Dictionary<int, Movie> All = new();

        public bool adult { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string release_date { get; set; }
        public string overview { get; set; }
        public string original_language { get; set; }
        public double? vote_average { get; set; }
        public string poster_path { get; set; }
        public int vote_count { get; set; }
        public string status { get; set; }
        public int? runtime { get; set; }
        public string homepage { get; set; }
        public Genres[] genres { get; set; }

        public Image poster_image { get; set; }
        public bool GotAllInfo { get; set; }

        public class Genres
        {
            public int id { set; get; }
            public string name { set; get; }

        }

        public void AddToDictionary()
        {
            if (!All.ContainsKey(this.id))
            {
                All.Add(this.id, this);
            }
        }
       
    }
}
