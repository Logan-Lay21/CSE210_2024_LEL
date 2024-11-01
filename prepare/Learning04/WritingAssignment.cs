using System;
using System.Security.Cryptography.X509Certificates;
public class WritingAssignment : Assignment {
    string _title = "";

    public WritingAssignment(string name, string topic, string title) : base(name,topic) {
        _title = title;
    }

    public string GetWritingInformation() {
        return $"{_title} by {base.GetStudentName()}";
    }

}