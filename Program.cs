using System;

namespace challengeWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int userInput = 0;
            int scoreSum = 0;
            double avgScoreResult = 0;

            while (userInput != -1)
            {
                Console.WriteLine("Please enter a valid integer between 0 and 20: ");
                string userInputString = Console.ReadLine();
                bool parseSuccess = int.TryParse(userInputString, out userInput);

                if (parseSuccess == true && userInput < 21 && userInput > -1)
                {
                    counter++;
                    scoreSum += userInput;
                    avgScoreResult = (double)scoreSum / (double)counter;
                    Console.WriteLine($"Current score sum is {scoreSum}, you've entered {counter} valid scores and current average score is {avgScoreResult}");

                }


                else if (userInput == -1)
                {
                    Console.WriteLine("Your average score will be revealed now");
                }

                else
                {
                    Console.WriteLine("You've entered an invalid value.");
                }
                
                
            }

            
            Console.WriteLine($"{avgScoreResult} is your definitive average score.");
            Console.Read();

        }
    }
}
