using System;

class Program
{
    static void Main(string[] args)
    {
        // Polynomial p = new Polynomial();
        Exponential e = new Exponential();
        NaturalLog n = new NaturalLog();
        SinCos sinCos = new SinCos();
        Calculator c = new Calculator();
        // Expression ex = new Expression();

        bool running = true;

        do {
            Console.Clear();
            Console.Write(@"
Welcome to the Integral Calculator! Please view the instructions before using the calculator. :)
Menu Options:
    1. Instructions
    2. Take Integral
    3. See Previous Integrals
    4. Quit
Select a choice from the menu: ");
        string choice = Console.ReadLine();
            // opt = int.Parse(choice);
            switch (choice) 

            {
                case "1": // View instructions
                Console.Clear();
                Console.WriteLine("This is not a crazy calculator or anything. As I go about completing this\nproject I will learn more about the abilities of the calculator and will\nhave more thorough instructions.");
                Console.WriteLine("\nPress any key to return to the menu");
                Console.ReadKey();

                    break;

                case "2": // Calculate the integral
                Console.Clear();
                
                // Call Expression and have the user define the bounds and expression value.
                // Call calculator and have it do big maths.
                Expression ex = new Expression(5, 10, "2x^2");
                ex.SplitExp();
                

                

                Console.WriteLine($"The integral of {ex.GetExpression()} from {ex.GetLowerBound()} to {ex.GetUpperBound()} is {c.CalcSum()}");

                Console.WriteLine("\nPress any key to return to the menu");
                Console.ReadKey();

                    break;

                case "3": //See previous answers

                // Print out previous answers, will store previous answers in Calculator. The list resets after the program quits.

                    break;

                case "4": //Quit
                running = false;
                    break;
            }
        } while (running == true);
    }
}