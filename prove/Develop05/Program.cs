using System;

class Program
{
    static void Main(string[] args)
    {
        Goalie G = new Goalie();
        string choice = "";

        bool running = true;
        do {
            Console.Clear();
            Console.Write(@"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ");


            choice = Console.ReadLine();
            // opt = int.Parse(choice);
            switch (choice) 
            {
                case "1": // Create New Goal
                    Console.Clear();

                    //Prompt the user for a goal type
                    //Create corresponding goal
                    //add to goal list
                    Simple simpleGoal = new Simple("the unseen", "You should not be seeing this", 20);
                    simpleGoal.CreateGoal();
                    G.AddGoal(simpleGoal);

                    Console.WriteLine(G.GetGoals());

                    Console.WriteLine(simpleGoal.GetName());

                    // Thread.Sleep(1000);



                    break;
                case "2": // List Goals
                    Console.Clear();
                    G.ListGoals();

                    Thread.Sleep(10000);
                    break;
                case "3": // Save Goals
                    Console.Clear();
                    break;
                case "4": // Load Goals
                    Console.Clear();
                    break;
                case "5": // Record Event
                    Console.Clear();
                    break;
                case "6": // Quit
                    running = false;
                    break;
            }
        } while (running);
    }
}