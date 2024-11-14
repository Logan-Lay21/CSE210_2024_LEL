using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal j = new();

        string choice = "";
        do 
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            
            if (choice == "1") { //Write
                j.InputNewEntry();
            }

            else if (choice == "2") { //Display
                j.DisplayJournal();
            }

            else if (choice == "3") { //Load
                Console.Write("Enter a filename: ");
                string filename = Console.ReadLine();
                j.LoadJournal(filename);
            }

            else if (choice == "4") { //Save
                Console.Write("Enter a filename: ");
                string filename = Console.ReadLine();
                j.WriteFile(filename);
            }

        } while (choice != "5"); //Quit
    }

}