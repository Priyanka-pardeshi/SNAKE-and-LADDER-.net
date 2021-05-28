using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeANDladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder GAME !");
            GAME objGame = new GAME();
            objGame.Play();
        }
    }
}
