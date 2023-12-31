using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGamesTest
{
    internal class Program
    {
        public static int opt_pos = 1;
        static void Main(string[] args)
        {
            int room = 0;
            while (room != -1)
            {
                Console.SetWindowSize(80, 20);
                Console.Clear();
                switch (room)
                {
                    case 0: room = Rooms.Menu(opt_pos); break;
                    case 1: room = Rooms.Juegos(opt_pos); break;
                    /*case 2: room = Rooms.Opciones(); break;*/

                    case 3: room = Rooms.GameSnake(); break;
                        /*case 4: room = Rooms.Room0(); break;*/
                }
            }
        }
    }
}
