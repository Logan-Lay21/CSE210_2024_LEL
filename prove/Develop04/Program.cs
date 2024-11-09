using System;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

    string choice = "";

    bool running = true;
    do {
        Console.Clear();
        Console.Write(@"
Menu Options:
    1. Start breathing activity
    2. Start reflect activity
    3. Start listing activity
    4. Quit
Select a choice from the menu: ");


        choice = Console.ReadLine();
        // opt = int.Parse(choice);
        switch (choice) 
        {
            case "1": // Breathe Activity
                Console.Clear();

                BreatheActivity BA = new BreatheActivity("breathe", "focus on your breathing by directing you to breathe in and out slowly. Clear your mind and focus on the air in your lungs");

                BA.RunBreathe();

                break;
            case "2": // Listing Activity
                Console.Clear();

                ReflectActivity RA = new ReflectActivity("reflect", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                RA.RunReflect();
                
                break;
            case "3": // Reflect Activity
                ListingActivity LA = new ListingActivity("listing", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
                LA.RunListing();
                break;
            case "4": // Quit
                running = false;
                break;
            default: // Default Message
                Console.WriteLine("Invalid input!");
                Thread.Sleep(1000);
                break;
        }
    } while (running != false);

    }

    // Research switch cases!!
}