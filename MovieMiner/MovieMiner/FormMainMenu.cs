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
           _=Search(tb_srchBox.Text);
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            cb_SrchType.SelectedIndex = 1;
        }

        async Task Search(string input)
        {
            dataGrid_srchResults.Visible = false;
            panel_movieData.Visible = false;
            btn_nxtPage.Visible = false;
            btn_prvsPage.Visible = false;
            label_pageCount.Text = "";
            label_searchResultMessage.Text = "Searching...";

            if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                switch (cb_SrchType.SelectedIndex)
                {
                    case 0:
                        if(int.TryParse(input, out int id))
                        {
                            Movie movie = await SearchEngine.SearchMovieById(id);

                            if (movie != null)
                            {
                                ResetResultTextBox();
                                await DisplaySelectedMovie(movie.id);

                                label_searchResultMessage.Text = "";
                                return;


                            }
                            else
                            {
                                label_searchResultMessage.Text = "Nothing found...";
                            
                            }
                        }
                        else
                        {
                            label_searchResultMessage.Text = "ID Invalid";

                        }

                        break;

                    case 1:
                       
                        SearchResults result = await SearchEngine.SearchMoviesByTitle(input);
                        label_pageCount.Text = $"Page {result.page} \nof {result.total_pages} pages";
                        if (result != null && result.results.Count > 0)
                        {

                            ResetResultTextBox();



                            foreach (Movie m in result.results)
                            {
                                dataGrid_srchResults.Rows.Add(new object[] { m.id, m.title, m.release_date });
                            }

                            await DisplaySelectedMovie(result.results[0].id);
                            dataGrid_srchResults.Visible = true;
                            label_searchResultMessage.Text = $"{result.total_results} movies found.";

                            return;

                        }
                        else
                        {
                            label_searchResultMessage.Text = "Nothing found..";

                        }
                        break;

                    default:
                        label_searchResultMessage.Text = "Search metod not chosen...";


                        break;

                }
            }

            else
            {
                label_searchResultMessage.Text = "Nothing found...";

            }

        }

        async Task DisplaySelectedMovie(int id)
        {

            if (!Movie.All[id].GotAllInfo)
            {
                Movie.All[id] = await SearchEngine.SearchMovieById(id);
            }

            Movie movie = Movie.All[id];
            PrintMovieValues(movie);
      
        }

        void PrintMovieValues(Movie movie)
        {
            pctrBox_poster.Image = movie.poster_image != null ? movie.poster_image : pctrBox_poster.ErrorImage;
            label_Title.Text = $"{movie.title}";
            label_rating.Text = $"Rating: {(movie.vote_count > 0 ? $"{movie.vote_average}%" : "(NR)")}";
            label_ReleaseDate.Text = $"Release date: {(movie.release_date.Length != 0 ? $"{movie.release_date} ({movie.status})" : "(Unknown)")}";
            label_Runtime.Text = $"Runtime: {(movie.runtime > 0 ? $"{movie.runtime} min" : "(Unknown)")}";
            label_orgLanguage.Text = $"Original language: {movie.original_language}";
            link_homepage.Text = $"Homepage: {movie.homepage}";
            link_poster.Text = $"Poster: {movie.poster_path}";
            rtb_overview.Text = movie.overview;
            panel_movieData.Visible = true;
        }



        void ResetResultTextBox()
        {

            dataGrid_srchResults.Rows.Clear();

        }

        private void cb_SrchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             int id = Convert.ToInt32(dataGrid_srchResults.SelectedRows[0].Cells["ID"].Value);

           _ =DisplaySelectedMovie(id);

            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_orgLanguage_Click(object sender, EventArgs e)
        {

        }

        private void label_searchResultMessage_Click(object sender, EventArgs e)
        {

        }

        private void label_ReleaseDate_Click(object sender, EventArgs e)
        {

        }

        private void btn_prvsPage_Click(object sender, EventArgs e)
        {

        }

        private void btn_nxtPage_Click(object sender, EventArgs e)
        {

        }
    }
}
