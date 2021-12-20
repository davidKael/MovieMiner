using System.Windows.Forms;

namespace MovieMiner
{
    internal static class FormHandler
    {
        public static string nextForm;

        public static void RunApp()
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