using System;
public class LectureEvent : Event {
    private string _type = "Lecture";
    private string _speaker;
    private string _capacity;
    public LectureEvent(string title, string description, Address address, string date, string time, string speaker, string capacity) : base(title, description, address, date, time) {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetLectureDetails() {
        return $"Type: {_type}\n{base.GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public string GetLectureShortDesc() {
        return $"{_type} - {_title} - {_date}";
    }
    public override string GetFullDetails() {
        return $"{base.GetStandardDetails()}\n\n{GetLectureDetails()}\n\n{GetLectureShortDesc()}\n====================\n\n";
    }
}