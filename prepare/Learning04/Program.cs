using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment a = new Assignment("Logan Lay", "Programming");
        // MathAssignment ma = new MathAssignment("Logan Lay", "Math", "7.3", "8-20");
        WritingAssignment wa = new WritingAssignment("Logan Lay", "English", "The Controversial Yet Meaningful Truth About Lorem Ipsum");


        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());

    }
}