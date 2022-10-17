namespace Trevisharp.Mathematics;

public static class Functions
{
    private static Variable _x = null;
    public static Variable x
    {
        get
        {
            if (_x == null)
                _x = new Variable("x");
            return _x;
        }
    }

    public static Function linear(double a, double b)
        => a * x + b;
    
    public static Function sin(Function f)
    {
        AggregativeFunction result = new AggregativeFunction();
        result.Aggregation = new SinAggregation();
        result.Inner = f;
        return result;
    }
}
