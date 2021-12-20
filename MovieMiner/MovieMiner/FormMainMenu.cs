using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MovieMiner
{
    public partial class FormMainMenu : Form
    {
        Dictionary<int, Image> images = new();

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
            label_searchResultMessage.Text = "Searching...";

            if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                switch (cb_SrchType.SelectedIndex)
                {
                    case 0:
                        Movie movie = await SearchEngine.SearchMovieById(input);

                        if (movie != null)
                        {
                            ResetResultTextBox();

                            PrintMovieValues(movie);
                            images.Clear();
                           _= LoadImage(movie);
                            

                        }
                        else
                        {
                            label_searchResultMessage.Text = "Nothing found...";
                        }
                        break;

                    case 1:
                        panel_movieData.Visible = false;
                        SearchResults result = await SearchEngine.SearchMoviesByTitle(input);

                        if (result != null && result.results.Count > 0)
                        {

                            ResetResultTextBox();


                            images.Clear();
                            foreach (Movie m in result.results)
                            {


                                _ = LoadImage(m);
                                dataGrid_srchResults.Rows.Add(new object[] { m.id, m.title, m.release_date });


                            }

                            await DisplaySelectedMovie(result.results[0].id.ToString());
                            dataGrid_srchResults.Visible = true;
                            label_searchResultMessage.Text = $"{result.total_results} movies found.";



                        }
                        else
                        {
                            label_searchResultMessage.Text = "Nothing found..";
                            panel_movieData.Visible = false;
                            dataGrid_srchResults.Visible = false;
                        }
                        break;

                    default:
                        label_searchResultMessage.Text = "Search metod not chosen...";
                        panel_movieData.Visible = false;
                        dataGrid_srchResults.Visible = false;
                        break;
                }
            }

            else
            {
                label_searchResultMessage.Text = "Nothing found...";
                panel_movieData.Visible = false;
                dataGrid_srchResults.Visible = false;
            }



        }

        async Task DisplaySelectedMovie(string id)
        {
            Movie movie = await SearchEngine.SearchMovieById(id);
            PrintMovieValues(movie);
            panel_movieData.Visible = true;
        }

        void PrintMovieValues(Movie movie)
        {
            
            //pctrBox_poster.ImageLocation = $"https://www.themoviedb.org/t/p/w1280{movie.poster_path}";

            label_Title.Text = $"{movie.title}";
            label_rating.Text = $"Rating: {movie.vote_average}%";
            label_ReleaseDate.Text = $"Release date: {movie.release_date}";
            label_Runtime.Text = $"Runtime: {movie.runtime} min";
            label_orgLanguage.Text = $"Original language: {movie.original_language}";
            rtb_overview.Text = movie.overview;

            if (images.TryGetValue(Convert.ToInt32(movie.id), out Image image))
            {
                pctrBox_poster.Image = image;
            }
            else
            {
                pctrBox_poster.Image = pctrBox_poster.ErrorImage;
            }


        }



        void ResetResultTextBox()
        {
            //rtb_SrchFindings.Text = "";
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
             string selected = dataGrid_srchResults.SelectedRows[0].Cells["ID"].Value.ToString();


            _ =DisplaySelectedMovie(selected);

            

        }

        internal async Task LoadImage(Movie m)
        {
            WebRequest request = WebRequest.Create($"https://www.themoviedb.org/t/p/w1280{m.poster_path}");
            
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    images.Add(m.id, Bitmap.FromStream(str));
                }

            }
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
    }
}
