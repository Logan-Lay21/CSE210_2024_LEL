using System;

public class Checklist : Goal {
    private int _checks = 0;
    private int _requiredChecks;
    private int _bonusPoints;


    public Checklist(string name, string description, int points) : base(name, description, points) {

    }

    public override void RecordEvent() {
        _checks++;

        //add bonus points to total points
        
        if (_checks == _requiredChecks) {
            _completed = true;
        }
    }
}