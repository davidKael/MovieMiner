using System;
using System.Windows.Forms;

namespace MovieMiner
{
    public partial class FormEnterAPI : Form
    {
        public FormEnterAPI()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (SearchEngine.TryKey(tb_apiInput.Text))
            {
                FormHandler.nextForm = "FormMainMenu";
                Close();
            }
            else
            {
                string message = "Invalid Api";
                MessageBox.Show(message, message);
            }
        }
    }
}