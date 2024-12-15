using System;
public class Running : Activity {
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes) {
        _distance = distance;
    }
    public override double GetDistance() {
        return _distance;
    }
    public override double GetSpeed() {
        return _distance / _minutes * 60;
    }
    public override double GetPace() {
        return _minutes / _distance;
    }
    public override string GetSummary() {
        return $"{_date} Running ({_minutes}) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}