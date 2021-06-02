using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 11);       
            string appName = "Number Guesser";
            string appVer = "1.0.0";
            string appAuthor = "Thisara Manohara";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} - ver:{1} by {2}", appName, appVer, appAuthor);
            Console.ResetColor();

            Console.Write("What's your name : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string inputName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello " + inputName);
            Console.ResetColor();

            Console.Write("Please guess a number between 1 - 10 --> ");
          
                int inputNumber = Convert.ToInt16(Console.ReadLine());
                Console.ResetColor();
            while (correctNumber != inputNumber)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Sorry not matched .please guess another number --> ");
                    Console.ResetColor();
                    inputNumber = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry something went wrong");
                    Console.Write("Sorry not matched .please guess another number --> ");
                    Console.ResetColor();
                    inputNumber = Convert.ToInt16(Console.ReadLine());
                    continue;
                }
            }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Hurrrrayyyyy !!!");
                Console.ResetColor();       
        }
    }
}
