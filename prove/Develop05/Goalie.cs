using System;

public class Goalie {

    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    private bool _allAreTrue = true;

    public void ListGoals() {

        int index = 1;

        Console.WriteLine("The goals are:");

        Console.WriteLine("---------------");

        foreach (Goal goal in _goals) {
            string name = goal.GetName();
            string description = goal.GetDescription();
            
            if (goal.GetCompleted()) {
                Console.WriteLine($"{index}. [X] {goal.DisplayGoal()})");
            }
            else {
                Console.WriteLine($"{index}. [ ] {goal.DisplayGoal()})");
            }

            index ++;
        }

        Console.WriteLine($"\nYou have {_totalPoints} points");
    }

    public void SaveGoals() {

        Console.Write("Please enter the name of your file? (Filetype included ex. 'txt')");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (Goal goal in _goals) {
                switch(goal.GetType().ToString()) {
                    case "Simple":
                        outputFile.WriteLine($"{1}~{goal.GetName()}~{goal.GetDescription()}~{goal.GetPoints()}~{goal.GetCompleted()}");
                    break;

                    case "Eternal":
                        outputFile.WriteLine($"{2}~{goal.GetName()}~{goal.GetDescription()}~{goal.GetPoints()}~{goal.GetIterations()}");

                    break;

                    case "Checklist":
                        outputFile.WriteLine($"{3}~{goal.GetName()}~{goal.GetDescription()}~{goal.GetPoints()}~{goal.GetChecks()}~{goal.GetRequiredChecks()}~{goal.GetBonusPoints()}");

                    break;
                }
            }
        }

    }

    public void LoadGoals() {

        Console.Write("What is the name of your file? (Filetype included ex. 'txt')");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {



            //For different goals: if (parts[0] = "1")
                //such and such: simple goal

            // Loads in previously made goals #Simple goal
            string[] parts = line.Split("~");

            if (parts[0] == "1") {
                Simple s = new Simple(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                _goals.Add(s);

                
                // Adds already completed points from loaded goals to total points
                if (bool.Parse(parts[4])) {
                    _totalPoints += int.Parse(parts[3]);
                }
            }

            // Loads in previously made goals #Eternal goal
            else if (parts[0] == "2") {
                Eternal e = new Eternal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]));
                _goals.Add(e);

                // Adds already completed points from loaded goals to total points
                _totalPoints += int.Parse(parts[3]) * int.Parse(parts[4]);
            }

            else if (parts[0] == "3") {
                Checklist c = new Checklist(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]));
                _goals.Add(c);

                // Adds already completed points from loaded goals to total points
                _totalPoints += int.Parse(parts[3]) * int.Parse(parts[4]);
                if (c.GetChecks() == c.GetRequiredChecks()) {
                    _totalPoints += c.GetBonusPoints();
                }
            }

        }
    }

    public void RecordGoalEvent() {
        //display list of goals with index
        _allAreTrue = true;

        foreach (Goal goal in _goals) {
            if (goal.GetCompleted() == false) {
                _allAreTrue = false;
            }
        }

        if (!_allAreTrue) {
            Console.WriteLine("The goals are:");

            Console.WriteLine("---------------");

            int index = 1;

            foreach (Goal goal in _goals) {
                string name = goal.GetName();
                string description = goal.GetDescription();
                
                if (goal.GetCompleted() == false) {
                    Console.WriteLine($"{index}. {name}");
                }
                index ++;
            }

            //get user input, ask for which goal to record

            Console.Write("\nWhich goal would you like to record?");
            int goalChoice = int.Parse(Console.ReadLine()) - 1;

            //_goals[index].RecordEvent()

            _goals[goalChoice].RecordEvent();
            //display current state of goals (checked, unchecked)

            Console.WriteLine($"Congratulations! You earned {_goals[goalChoice].GetPoints()} points");
            
            if (_goals[goalChoice].GetChecks() == _goals[goalChoice].GetRequiredChecks()) {
                Console.WriteLine($"Congratulations! You earned {_goals[goalChoice].GetBonusPoints()} points");
                _totalPoints += _goals[goalChoice].GetBonusPoints();

            }
            //display total points

            _totalPoints += _goals[goalChoice].GetPoints();
        }
        else if (_allAreTrue) {
            Console.WriteLine("You have no goals to record!");
        }

    }

    public void AddGoal(Goal goal) {
        _goals.Add(goal);
    }

    public Goal GetGoals() {
        return _goals[0];
    }

    public int GetTotalPoints() {
        return _totalPoints;
    }

    
}