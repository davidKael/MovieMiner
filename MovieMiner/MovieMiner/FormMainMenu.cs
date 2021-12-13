using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MovieMiner
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
           if(tb_srchBox.Text.Length > 0)
           {
                _=Search(tb_srchBox.Text);
           }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
        async Task Search(string input)
        {

            Movie movie = await SearchEngine.SearchMovieById(input);

            if(movie != null) 
            {


                rtb_SrchFindings.Text = $"Title: {movie.title} ({movie.release_date.Year})\n";
                rtb_SrchFindings.Text += $"Genre: ";
                foreach (Movie.Genres g in movie.genres)
                {
                    rtb_SrchFindings.Text += $"{g.name} ";
                }
                rtb_SrchFindings.Text += "\n";
                rtb_SrchFindings.Text += $"Runtime: {movie.runtime} min\n";
                rtb_SrchFindings.Text += $"Overview: {movie.overview}\n\n";
                rtb_SrchFindings.Text += $"Original Language: {movie.original_language}\n";
                rtb_SrchFindings.Text += $"Rating: {movie.vote_average * 100}\n";
                rtb_SrchFindings.Text += $"Released: {movie.release_date.ToShortDateString()}\n";
                rtb_SrchFindings.Text += $"HomePage: {movie.homepage}\n";
                rtb_SrchFindings.Text += $"PosterLink: https://www.themoviedb.org/t/p/w1280{movie.poster_path}\n";



            }
            else
            {
                rtb_SrchFindings.Text = "nothing found";
            }
            


            
        }
    }
}
