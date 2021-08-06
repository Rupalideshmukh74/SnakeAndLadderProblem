using System;

namespace snakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Problem");
            int startPoint = 0;
            int position = 0;
            Random random = new Random();
            int rollDieNo = random.Next(1, 7);
            int optionOfGame = random.Next(0, 3);
            Console.WriteLine("Roll Die Number " + rollDieNo);
            switch (optionOfGame)
            {
                case 0:
                    Console.WriteLine("Position : " + position);
                    break;
                case 1:
                    position += rollDieNo;
                    Console.WriteLine("Position : " + position);
                    break;

                case 2:
                    position -= rollDieNo;
                    Console.WriteLine("Position : " + position);
                    break;

                default:
                    break;
            }  
        }
    }
}
