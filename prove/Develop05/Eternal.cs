using System;

public class Eternal : Goal {

    private int _iterations = 0;

    public Eternal() {}
    public Eternal(string name, string description, int points) : base(name, description, points) {
    
    }

    public Eternal(string name, string description, int points, int iterations) : base(name, description, points) {
        _iterations = iterations;
    }

    public override void RecordEvent() {
        _iterations++;
    }

    public override string DisplayGoal()
    {
        return $"{_name} ({_description}) - Completed {_iterations} time(s)";
    }
    
    public override int GetIterations() {
        return _iterations;
    }
}