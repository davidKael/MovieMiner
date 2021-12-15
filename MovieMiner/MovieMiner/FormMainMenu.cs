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
            /*
            Movie movie = await SearchEngine.SearchMovieById(input);

            if(movie != null) 
            {
                ResetResultTextBox();
               
              PrintMovieValues(movie);


            }
            else
            {
                rtb_SrchFindings.Text = "nothing found";
            }
            
            */

            SearchResults result = await SearchEngine.SearchMoviesByTitle(input);

            if (result != null)
            {
                ResetResultTextBox();
                rtb_SrchFindings.Text = $"Movies: {result.total_results.ToString()}\n\n";
                rtb_SrchFindings.Text += "-----------------------------------------------------------------------------------------------\n";
                foreach (Movie m in result.results)
                {
                    rtb_SrchFindings.Text += "\n";
                    PrintMovieValues(m);
                    rtb_SrchFindings.Text += "\n-----------------------------------------------------------------------------------------------\n";
                }
             


            }
            else
            {
                rtb_SrchFindings.Text = "nothing found";
            }


        }


        void PrintMovieValues(Movie movie)
        {
            foreach (string line in movie.GetAllInfo())
            {
                rtb_SrchFindings.Text += line + "\n";
            }
        }

        void ResetResultTextBox()
        {
            rtb_SrchFindings.Text = "";
        }
    }
}
