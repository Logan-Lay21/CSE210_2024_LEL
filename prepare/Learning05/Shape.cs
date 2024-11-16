using System;
using System.Dynamic;

public class Shape {
    string _color = "";

    public Shape(string color) {
        _color = color;
    }

    public string GetColor() {
        return _color;
    }

    public void SetColor(string color) {
        _color= color;
    }

    virtual public double GetArea() {
        return 0;
    }

}

