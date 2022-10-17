using System.Collections.Generic;

namespace Trevisharp.Mathematics;

public interface IAssociation
{
    double Calculate(IEnumerable<Function> fs, double x);
    Function Derive(IEnumerable<Function> fs);
    Function Integrate(IEnumerable<Function> fs);
    string Show(IEnumerable<Function> fs);
}