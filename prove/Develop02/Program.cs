using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new();
        // journal1.InputNewEntry();
        // journal1.InputNewEntry();
        // journal1.WriteFile();
        // journal1.DisplayJournal();
        // Entry test = new();
        // test.InputEntry();
        // test.DisplayEntry();
        int choice = 0;
        do 
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            Console.Write("What would you like to do? ");
            choice = int(Console.ReadLine());
            
            if (choice == 1) {

            }

            else if (choice == 2) {

            }

            else if (choice == 3) {
                
            }

            else if (choice == 4) {
                
            }

        } while (choice != 5);
    }

}
// string filename = "myFile.txt";
// string[] lines = System.IO.File.ReadAllLines(filename);

// foreach (string line in lines)
// {
//     Console.WriteLine(line);
// }
/* 
1. Write
2. Display
3. Load
4. Save
5. Quit
*/