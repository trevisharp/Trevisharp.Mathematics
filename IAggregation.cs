namespace Trevisharp.Mathematics;

public interface IAggregation
{
    double Calculate(Function f, double x);
    Function Derive(Function f);
    Function Integrate(Function f);
    string Show(Function f);
}