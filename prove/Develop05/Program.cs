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
                    Console.Write(@"
1. Simple
2. Eternal
3. Checklist

What kind of goal would you like to make? 
");

                    string goalChoice = Console.ReadLine();

                    switch (goalChoice)
                    {
                        case "1": //Simple goal
                            Console.Clear();
                            Simple simpleGoal = new Simple();
                            //Create corresponding goal
                            simpleGoal.CreateGoal();
                            //add to goal list
                            G.AddGoal(simpleGoal);
                            break;
                        
                        case "2": //Eternal goal
                            Console.Clear();
                            Eternal eternalGoal = new Eternal();
                            //Create eternal goal
                            eternalGoal.CreateGoal();
                            //add goal to list
                            G.AddGoal(eternalGoal);
                            break;
                        case "3": //Checklist goal
                            Console.Clear();
                            Checklist cGoal = new Checklist();
                            //Create eternal goal
                            cGoal.CreateGoal();
                            //add goal to list
                            G.AddGoal(cGoal);
                            break;
                    }
                    



                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();



                    break;
                case "2": // List Goals
                    Console.Clear();
                    G.ListGoals();

                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();

                    break;


                case "3": // Save Goals
                    Console.Clear();

                    G.SaveGoals();
                    
                    Console.WriteLine("\nSaved!");

                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();

                    break;


                case "4": // Load Goals
                    Console.Clear();

                    G.LoadGoals();

                    Console.WriteLine("\nLoaded!");

                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();

                    break;


                case "5": // Record Event
                    Console.Clear();

                    G.RecordGoalEvent();

                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();

                    break;
                case "6": // Quit
                    running = false;
                    break;
            }
        } while (running);
    }
}