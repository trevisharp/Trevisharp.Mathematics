using System.Text;
using System.Collections.Generic;

namespace Trevisharp.Mathematics;

public class MultiplyAssociation : IAssociation
{
    public double Calculate(IEnumerable<Function> fs, double x)
    {
        double result = 1.0;
        foreach (var f in fs)
            result *= f[x];
        return result;
    }

    public Function Derive(IEnumerable<Function> fs)
    {
        throw new System.NotImplementedException();
    }

    public Function Integrate(IEnumerable<Function> fs)
    {
        throw new System.NotImplementedException();
    }

    public string Show(IEnumerable<Function> fs)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var f in fs)
            sb.Append(f);
        return sb.ToString();
    }
}
