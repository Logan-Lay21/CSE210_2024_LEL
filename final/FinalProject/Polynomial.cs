using System;
using MathNet.Numerics;

public class Polynomial: Antiderivative {
    // public string PolyInt()
    // {
    //     // Define the function to integrate
    //     Func<double, double> f = (x) => x * x; // f(x) = x^2

    //     // Define integration bounds
    //     double lowerBound = 0;
    //     double upperBound = 5;
    //     long numberOfSteps = 10000000000000; // Increase for more precision

    //     // Trapezoidal rule implementation
    //     double result = TrapezoidalIntegration(f, lowerBound, upperBound, numberOfSteps);

    //     // Output the result
    //     return $"The integral of f(x) = x^2 from 0 to 1 is approximately: {result:F4}";
    // }

    // // Custom trapezoidal integration method
    // public static double TrapezoidalIntegration(Func<double, double> f, double a, double b, long n)
    // {
    //     double h = (b - a) / n;
    //     double sum = 0.5 * (f(a) + f(b));

    //     for (int i = 1; i < n; i++)
    //     {
    //         double x = a + i * h;
    //         sum += f(x);
    //     }

    //     return sum * h;
    // }
    public override string TakeAntiDer() {
        return "Polynomial";
    }
}