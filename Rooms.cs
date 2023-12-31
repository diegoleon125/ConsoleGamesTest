using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGamesTest
{
    internal class Rooms
    {
        #region Menus
        public static int Menu(int pos = 1)
        {
            string[] options = { "Juegos", "Opciones", "Salir" };
            string text = Functions.Screen_title("A R C A D E") +
                Functions.Screen_options(options, pos);
            Console.Write(text);
            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            if (consoleKey == ConsoleKey.Enter)
            {
                Program.opt_pos = 1;
                if (pos == options.Length) return -1;
                return pos;
            }
            else if (consoleKey == ConsoleKey.DownArrow || consoleKey == ConsoleKey.S)
            {
                if (pos + 1 > options.Length) Program.opt_pos = 0;
                Program.opt_pos += 1;
            }
            else if (consoleKey == ConsoleKey.UpArrow || consoleKey == ConsoleKey.W)
            {
                if (pos - 1 < 1) Program.opt_pos = options.Length + 1;
                Program.opt_pos -= 1;
            }
            return 0;
        }
        public static int Juegos(int pos = 1)
        {
            string[] options = { "GameSnake", "Pacman", "MarioBros", "Salir" };
            string text = Functions.Screen_title("A R C A D E") +
                Functions.Screen_options(options, pos);
            Console.Write(text);
            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            if (consoleKey == ConsoleKey.Enter)
            {
                Program.opt_pos = 1;
                if (pos == options.Length) return 0;
                return pos + 2;
            }
            else if (consoleKey == ConsoleKey.DownArrow || consoleKey == ConsoleKey.S)
            {
                if (pos + 1 > options.Length) Program.opt_pos = 0;
                Program.opt_pos += 1;
            }
            else if (consoleKey == ConsoleKey.UpArrow || consoleKey == ConsoleKey.W)
            {
                if (pos - 1 < 1) Program.opt_pos = options.Length + 1;
                Program.opt_pos -= 1;
            }
            return 1;
        }
        public static int Opciones(int pos = 1)
        {
            return 0;
        }
        #endregion

        #region Juegos
        public static int GameSnake(int option = 1)
        {
            //room create
            var game = true;
            char[,] screen = new char[80, 19];
            char[,] snake = new char[80, 19];
            snake[40, 9] = '█';
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    if (i == 0 || i == 18) screen[j, i] = '█';
                    else if (j == 0 || j == 79) screen[j, i] = '█';
                    Console.Write(screen[j, i]);
                }
                if (i != 18) Console.Write("\n");
                Thread.Sleep(50);
            }
            //room loop
            while (game)
            {
                Console.Clear();
                string textscreen = "";
                for (int i = 0; i < 19; i++)
                {
                    for (int j = 0; j < 80; j++)
                    {
                        if (snake[j, i] == '█')
                        {
                            textscreen += snake[j, i];
                        }
                        else
                        {
                            textscreen += screen[j, i];
                        }
                    }
                    if (i != 18) textscreen += "\n";
                }
                Console.Write(textscreen);
                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                if (consoleKey == ConsoleKey.Escape)
                {
                    return 1;
                }
                else if (consoleKey == ConsoleKey.Enter)
                {

                }
                else if (consoleKey == ConsoleKey.UpArrow)
                {

                }

            }
            //room end
            return option;
        }


        #endregion
    }
}
