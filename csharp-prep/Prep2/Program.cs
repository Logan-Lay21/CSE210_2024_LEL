using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }

        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }

        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }

        else if (grade < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is a(n) {letterGrade}.");

        if (grade > 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }

        if (grade < 70)
        {
            Console.WriteLine("You failed the class, better luck next time! Maybe invest in a planner! ;)");
        }

    }
}

// Testing!