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
                ResetResultTextBox();
               
                foreach (string line in movie.GetAllInfo())
                {
                    rtb_SrchFindings.Text += line + "\n";
                }



            }
            else
            {
                rtb_SrchFindings.Text = "nothing found";
            }
            


            
        }

        void ResetResultTextBox()
        {
            rtb_SrchFindings.Text = "";
        }
    }
}
