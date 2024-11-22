using System;

public abstract class Goal {
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal() {}
    public Goal(string name, string description, int points) {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    public Goal(string name, string description, int points, bool completed) {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }

    public virtual void CreateGoal() {
        Console.Write("What would you like to name your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the description of your goal? ");
        _description = Console.ReadLine();
        Console.Write("How many points is this worth? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual int GetIterations() {
        return 0;
    }

    public virtual int GetChecks() {
        return 0;
    }

    public virtual int GetRequiredChecks() {
        return 100;
    }

    public virtual int GetBonusPoints() {
        return 0;
    }

    public abstract void RecordEvent();

    public abstract string DisplayGoal();

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