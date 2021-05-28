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

            //roll dice
           // int dice = objRandom.Next(1,6);

            while (start >= 0 & start <= 100)
            {
                int dice = objRandom.Next(1, 6);
                Console.WriteLine("Your dice number is " + dice + " Do Yoy wanna play?? y/n");
                String answer = Convert.ToString(Console.ReadLine());
                if (answer == "y")
                {
                    //Choice to check its snake or ladder
                    int choice = objRandom.Next(1, 2);
                    switch (choice)
                    {
                        case 1:
                            start = start + dice;
                            if (start >= 100)
                            {
                                Console.WriteLine("Congratulations ! You're winner :) ");
                                break;

                            }
                            if (start == 0)
                            {
                                Console.WriteLine("You Lose better luck next time :( ");
                            }
                            else
                            {
                                Console.WriteLine("Congo its Ladder.And your score is:" + start);
                            }
                            break;

                        case 2:
                            if (start < 0)
                            {
                                Console.WriteLine("Lose");
                            }
                            else
                            {
                                start = start - dice;
                            }
                            Console.WriteLine("Oops its Snake. and your score is:" + start);
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You'll reamain at same position " + start);
                }
            }
            
        }
    }
}
