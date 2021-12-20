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
