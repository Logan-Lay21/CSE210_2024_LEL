using System;
public class OutdoorEvent : Event {
    private string _type = "Outdoor";
    private string _weatherStatement;
    public OutdoorEvent(string title, string description, Address address, string date, string time, string weatherStatement) : base(title, description, address, date, time) {
        _weatherStatement = weatherStatement;
    }
    public string GetOutdoorDetails() {
        return $"Type: {_type}\n{base.GetStandardDetails()}\nWeather: {_weatherStatement}";
    }
    public string GetOutdoorShortDesc() {
        return $"{_type} - {_title} - {_date}";
    }
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\n\n{GetOutdoorDetails()}\n\n{GetOutdoorShortDesc()}\n====================\n\n";
    }
}