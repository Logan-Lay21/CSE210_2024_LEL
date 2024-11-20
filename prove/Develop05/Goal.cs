using System;

public abstract class Goal {
    private string _name;
    private string _description;
    private int _points;
    protected bool _completed;


    public Goal(string name, string description, int points) {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    public virtual void CreateGoal() {
        Console.Write("What would you like to name your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the description of your goal?");
        _description = Console.ReadLine();
        Console.Write("How many points is this worth");
        _points = int.Parse(Console.ReadLine());
    }



    public abstract void RecordEvent();

    public string GetName() {
        return _name;
    }

    public string GetDescription() {
        return _description;
    }

    public int GetPoints() {
        return _points;
    }

    public bool GetCompleted() {
        return _completed;
    }


}