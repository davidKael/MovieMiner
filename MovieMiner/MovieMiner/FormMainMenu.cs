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
                            LoadImage(movie);
                            

                        }
                        else
                        {
                            rtb_SrchFindings.Text = "Nothing found...";
                        }
                        break;

                    case 1:

                        SearchResults result = await SearchEngine.SearchMoviesByTitle(input);

                        if (result != null && result.results.Count > 0)
                        {
                            /*


                             ResetResultTextBox();
                             rtb_SrchFindings.Text = $"Movies: {result.total_results.ToString()}\n\n";
                             rtb_SrchFindings.Text += "-----------------------------------------------------------------------------------------------\n";

                             foreach (Movie m in result.results)
                             {
                                 rtb_SrchFindings.Text += "\n";
                                 PrintMovieValues(m);
                                 rtb_SrchFindings.Text += "\n-----------------------------------------------------------------------------------------------\n";
                             }

                             */
                            ResetResultTextBox();
                            images.Clear();
                            foreach (Movie m in result.results)
                            {

                               
                                LoadImage(m);
                                dataGrid_srchResults.Rows.Add(new object[] {m.id, m.title, m.release_date });


                            }

                            dataGrid_srchResults.ClearSelection();

                        }
                        else
                        {
                            rtb_SrchFindings.Text = "Nothing found...";
                        }
                        break;

                    default:
                        rtb_SrchFindings.Text = "Search metod not chosen...";
                        break;
                }
            }

            else
            {
                rtb_SrchFindings.Text = "Nothing found...";
            }



        }

        async Task DisplaySelectedMovie(string id)
        {
            Movie movie = await SearchEngine.SearchMovieById(id);
            PrintMovieValues(movie);
        }

        void PrintMovieValues(Movie movie)
        {
            rtb_SrchFindings.Text = "";
            //pctrBox_poster.ImageLocation = $"https://www.themoviedb.org/t/p/w1280{movie.poster_path}";




            foreach (string line in movie.GetAllInfo())
            {
                
                rtb_SrchFindings.Text += line + "\n";
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

            if (images.TryGetValue(Convert.ToInt32(selected), out Image image))
            {
                pctrBox_poster.Image = image;
            }
            else
            {
                pctrBox_poster.Image = pctrBox_poster.ErrorImage;
            }

            _ =DisplaySelectedMovie(selected);

            

        }

        internal void LoadImage(Movie m)
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
    }
}
