using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGamesTest
{
    internal class Functions
    {
        public static string Screen_title(string title, char? space1 = null)
        {
            int stringlength = title.Length;
            int pads = ((80 - stringlength) / 2) - 1;
            char spc1 = '=';
            //string spc2 = "||";
            if (space1.HasValue) spc1 = space1.Value;
            string text =
                "\n".PadLeft(80, spc1) +
                "||" + title.PadLeft(pads + stringlength) + "||\n".PadLeft(pads) +
                "\n".PadLeft(80, spc1);
            return text;
        }
        public static string Screen_options(string[] text0, int pos = 0)
        {
            string text = "";
            int cont = text0.Length;
            for (int i = 0; i < cont; i++)
            {
                string val = " ";

                if (i == pos - 1) val = "> ";
                int stringlength = text0[i].Length;
                int pads = ((80 - stringlength) / 2) - 1;
                text += "||" + val.PadLeft(pads) + text0[i].PadLeft(stringlength) + "||\n".PadLeft(pads);
            }
            text += "\n".PadLeft(80, '=');
            return text;
        }
        public static int GetOption(string texto, int limite)
        {
            bool correcto = false;
            int option = 0;
            while (!correcto)
            {
                Console.Write(texto);
                string optiontexto = Console.ReadLine();
                correcto = int.TryParse(optiontexto, out option);
                if (option < 1 || option > limite) correcto = false;
                if (!correcto)
                {
                    Console.WriteLine("Ingrese una opción correcta.");
                }
            }
            return option;
        }
    }
}
