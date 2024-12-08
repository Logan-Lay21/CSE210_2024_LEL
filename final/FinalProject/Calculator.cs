using System;

public class Calculator {
    private List<int> solutions = new List<int>();
    public int CalcUpperBound() {
        return 0;
    }

    public int CalcLowerBound() {
        return 0;
    }

    public int CalcSum() {
        int sum = CalcUpperBound() - CalcLowerBound();
        solutions.Add(sum);
        return sum;
    }
}