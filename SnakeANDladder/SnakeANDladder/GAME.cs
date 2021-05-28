using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeANDladder
{
    class GAME
    {
        public void Play()
        {
            Console.WriteLine("All the best For Game Play! ");
            int start = 0;
            //Console.WriteLine("You're initially at "+start);
            Random objRandom = new Random();
            int dice = objRandom.Next(1,6);
            Console.WriteLine("Your Dice number is:"+dice);
        }
    }
}
