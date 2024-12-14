using System;
using System.Text.RegularExpressions;

public class Expression {
    private int _upperBound = 1;
    private int _lowerBound = 0;
    private string _expression = "";
    private List<string> _terms = new List<string>();
    public Expression(int lower, int upper, string expression) {
        _lowerBound = lower;
        _upperBound = upper;
        _expression = expression;
    }
    public Expression() {}

    public void SplitExp() {
        _terms.AddRange(Regex.Split(_expression, "[-+]"));
        foreach (string term in _terms) {
            if (term.Contains("x")) {
                Polynomial p = new Polynomial(term);
                Console.WriteLine(p.TakeAntiDer());
            }
        }
    }
    public int GetLowerBound() {
        return _lowerBound;
    }
    public int GetUpperBound() {
        return _upperBound;
    }
    public string GetExpression() {
        return _expression;
    }
}