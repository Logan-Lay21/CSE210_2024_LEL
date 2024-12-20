using System;
public class Swimming : Activity {
    private int _laps;
    public Swimming(string date, int minutes, int laps) : base(date, minutes) {
        _laps = laps;
    }
    public override double GetDistance() {
        return _laps * (50.0/1000.0) * 0.62;
    }
    public override double GetSpeed() {
        return GetDistance() / _minutes * 60;
    }
    public override double GetPace() {
        return _minutes / GetDistance();
    }
    public override string GetSummary() {
        return $"{_date} Swimming ({_minutes}) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}