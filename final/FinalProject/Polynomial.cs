using System;
using MathNet.Numerics;

public class Polynomial: Antiderivative {
    public Polynomial(int coefficient, string symbol, int power) : base(coefficient, symbol, power) {
        _coefficient = coefficient;
        _symbol = symbol;
        _power = power;
    }
    public Polynomial(string term) {
        char[] terms = term.ToCharArray();
        _coefficient = int.Parse(terms[0].ToString());
        _symbol = terms[1].ToString();
        _power = int.Parse(terms[3].ToString());
    }
    public override string TakeAntiDer() {
        _power = _power + 1;
        return $"{_coefficient}*({_symbol}/{_power})^{_power}";
        
    }
}