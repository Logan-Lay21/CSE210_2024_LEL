using System;
public class ReceptionEvent : Event {
    private string _type = "Reception";
    private string _contactRSVP;
    public ReceptionEvent(string title, string description, Address address, string date, string time, string contactRSVP) : base(title, description, address, date, time) {
        _contactRSVP = contactRSVP;
    }
    public string GetReceptionDetails() {
        return $"Type: {_type}\n{base.GetStandardDetails()}\nRSVP contact: {_contactRSVP}";
    }
    public string GetReceptionShortDesc() {
        return $"{_type} - {_title} - {_date}";
        }
    public override string GetFullDetails() {
        return $"{base.GetStandardDetails()}\n\n{GetReceptionDetails()}\n\n{GetReceptionShortDesc()}\n====================\n\n";
    }
}