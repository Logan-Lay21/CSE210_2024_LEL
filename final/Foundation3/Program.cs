using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address addy1 = new Address("123 Main St", "New York", "NY", "USA");
        OutdoorEvent oe = new OutdoorEvent("Water fight", "Bring your swim trunks and water guns!", addy1, "Dec 15", "5:00pm", "It will rain :)");
        Console.WriteLine(oe.GetFullDetails());

        Address addy2 = new Address("221B Baker Street", "London", "NY", "UK");
        LectureEvent le = new LectureEvent("Investigation 101", "Learn the basics investigating from a professional!", addy2, "Jan 1", "7:00pm", "Sherlock Holmes", "15");
        Console.WriteLine(le.GetFullDetails());

        Address addy3  = new Address("777 Beach Front Dr", "Miami", "FL", "USA");
        ReceptionEvent re = new ReceptionEvent("Wedding", "Please come to the reception!", addy3, "Dec 31", "7:00pm", "Logan Lay (142)-675-4325");
        Console.WriteLine(re.GetFullDetails());
    }
}