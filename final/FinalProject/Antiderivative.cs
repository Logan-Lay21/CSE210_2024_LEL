using MathNet.Numerics;
using MathNet.Numerics.Integration;
using System;

public abstract class Antiderivative {
    protected int _coefficient = 1;
    protected string _symbol = "";
    protected int _power = 1;
    protected string _polynomial = "";


    public Antiderivative() {}
    public Antiderivative(int coefficient, string symbol, int power) {
        _coefficient = coefficient;
        _symbol = symbol;
        _power = power;
    }

    public Antiderivative(string symbol, int power) {
        _symbol = symbol;
        _power = power;
    }

    public Antiderivative(string symbol) {
        _symbol = symbol;
    }


    public virtual string TakeAntiDer() {
        return "Antiderivative";
    }

    public int GetCoefficient() {
        return _coefficient;
    }

    public string GetSymbol() {
        return _symbol;
    }

    public int Getpower() {
        return _power;
    }
}