using System;
public class Event {
    protected string _title;
    protected string _description;
    protected Address _address;
    protected string _date;
    protected string _time;
    public Event(string title, string description, Address address, string date, string time) {
        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;
    }
    public string GetStandardDetails() {
        return $"{_title} - {_description}\n{_date} @ {_time}\n{_address.GetAddressLabel()}";
    }
    public virtual string GetFullDetails() {
        return GetStandardDetails();
    }
}