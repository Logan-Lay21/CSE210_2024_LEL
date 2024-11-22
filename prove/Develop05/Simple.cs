using System;

public class Simple : Goal {

    public Simple() {}
    public Simple(string name, string description, int points) : base(name, description, points) {

    }

    public Simple(string name, string description, int points, bool completed) : base(name, description, points, completed) {

    }

    public override void RecordEvent()
    {
        _completed = true;
        
    }

    public override string DisplayGoal()
    {
        return $"{_name} ({_description})";
    }
}