using System;

namespace Trevisharp.Mathematics.Calculus;

public record SinAggregation : IAggregation
{
    public double Calculate(Function f, double x)
        => Math.Sin(f[x]);

    public Function Derive(Function f)
    {
        throw new NotImplementedException();
    }

    public Function Integrate(Function f)
    {
        throw new NotImplementedException();
    }

    public string Show(Function f)
        => $"sin({f})";
}