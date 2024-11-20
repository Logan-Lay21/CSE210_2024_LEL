using System;

public class Eternal : Goal {

    private int _iterations = 0;

    public Eternal(string name, string description, int points) : base(name, description, points) {
    
    }

    public override void RecordEvent() {
        _iterations++;
    }
}