using System;

public class Checklist : Goal {
    private int _checks = 0;
    private int _requiredChecks;
    private int _bonusPoints;

    public Checklist() {}
    public Checklist(string name, string description, int points, int checks, int requiredChecks, int bonusPoints) : base(name, description, points) {
        _checks = checks;
        _requiredChecks = requiredChecks;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent() {
        _checks++;

        //add bonus points to total points
        
        if (_checks == _requiredChecks) {
            _completed = true;
        }
    }

    public override string DisplayGoal()
    {
        return $"{_name} ({_description}) - {_checks}/{_requiredChecks}";
    }

    public override void CreateGoal() {
        Console.Write("What would you like to name your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the description of your goal? ");
        _description = Console.ReadLine();
        Console.Write("How many points is this worth? ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times would have to do this until it is completed?");
        _requiredChecks = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points will you get for completing this goal?");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int GetChecks() {
        return _checks;
    }

    public override int GetRequiredChecks() {
        return _requiredChecks;
    }

    public override int GetBonusPoints()
    {
        return _bonusPoints;
    }
}