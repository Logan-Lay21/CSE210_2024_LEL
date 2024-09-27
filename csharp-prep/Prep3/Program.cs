using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {   
        string answer="yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1,100);
            int guess=0;
            int counter=0;

            // Console.Write("What is the magic number? ");
            // string magicString = Console.ReadLine();
            // magicNum = int.Parse(magicString);

            do 
            {   
                counter++;
                Console.Write("What is your guess? ");
                string guessString= Console.ReadLine();
                guess = int.Parse(guessString);

                if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {counter} guess(es)!");
                }

            } while (guess != magicNum);
            Console.Write("Would you like to play again? ");
            answer = Console.ReadLine();
        } while (answer == "yes");
    }
}