using System;

namespace snakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Problem");
           
            int position = 0;
            Random random = new Random();
            int rollDieNo = random.Next(1, 7);
            int optionOfGame = random.Next(0, 3);
            Console.WriteLine("Roll Die Number " + rollDieNo);

            while (position != 100)
            {
                // generating Random Numbers for Die and Game Options
                rollDieNo = random.Next(1, 7);
                optionOfGame = random.Next(0, 3);

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
                        if (position > 100)
                            break;
                        else if (position < 0)
                            position = 0;
                }
                //Display Position Number
                Console.WriteLine("You Won ! Reached at : " + position);
            }
        }
           
    }
}
   

