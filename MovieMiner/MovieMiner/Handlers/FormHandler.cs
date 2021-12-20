using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMiner
{
    static class FormHandler
    {
        public static string nextForm;

        public static void RunForms()
        {
            bool isClosingApp = false;

            if (SearchEngine.GetKey())
            {
                nextForm = "FormMainMenu";
            }
            else
            {
                nextForm = "FormEnterAPI";
            }

            while (!isClosingApp)
            {
                switch (nextForm)
                {
                    case "FormEnterAPI":
                        nextForm = "";
                        Application.Run(new FormEnterAPI());
                        break;
                    case "FormMainMenu":
                        nextForm = "";
                        Application.Run(new FormMainMenu());
                        break;
                    default:
                        isClosingApp = true;
                        break;

                }
            }

              


        }
    }
}
