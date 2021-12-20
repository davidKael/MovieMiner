using System.Collections.Generic;

namespace MovieMiner
{
    internal class SearchResults
    {
        public static string CurrSearchWord;
        public static int CurrPage;

        public int page { get; set; }
        public List<Movie> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}