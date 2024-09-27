using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input=0;
        int sum=0;
        int largest=-1;
        int smallest=999999999;
        int div=0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            string numberEnt = Console.ReadLine();
            input = int.Parse(numberEnt);
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        foreach (int number in numbers)
        {
            sum=sum+number;
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallest)
            {
                smallest = number;
            }
            div++;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/div}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
    }
}
// for number in numbers:
//     if number > best:
//         best = number