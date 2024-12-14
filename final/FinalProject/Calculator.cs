using System;

public class Calculator {
    private List<Antiderivative> antiderivatives = new List<Antiderivative>();
    private List<int> solutions = new List<int>();
    public int CalcUpperBound() {
        Expression ex = new Expression();
        // int.Parse(ex.SplitExp());
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