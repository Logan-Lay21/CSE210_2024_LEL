using System;

public class Goalie {

    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void ListGoals() {
        foreach (Goal goal in _goals) {
            string name = goal.GetName();
            string description = goal.GetDescription();
            
            if (goal.GetCompleted()) {
                Console.WriteLine($"[X] {name} ({description})");
            }
            else {
                Console.WriteLine($"[ ] {name} ({description})");
            }
            
        }
    }

    public void SaveGoals() {

    }

    public void LoadGoals() {

    }

    public void RecordGoalEvent() {
        //display list of goals with index
        //get user input, ask for which goal to record
        //_goals[index].RecordEvent()
        //display current state of goals (checked, unchecked)
        //display total points
        // _totalPoints += _goals[index].getPoints() 
        // !!!!Dont forget to think about how bonus points will be added!!!!
    }

    public void AddGoal(Goal goal) {
        _goals.Add(goal);
    }

    public Goal GetGoals() {
        return _goals[0];
    }

    
}