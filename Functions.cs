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
    {
        return a * x + b;
    }
}
