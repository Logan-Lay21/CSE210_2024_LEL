using System;

public class Expression {
    private int _upperBound = 1;
    private int _lowerBound = 0;
    private string _expression = "";
    public Expression(int lower, int upper, string expression) {
        _lowerBound = lower;
        _upperBound = upper;
        _expression = expression;
    }
    public Expression() {}

    public string SplitExp() {
        return _expression;
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