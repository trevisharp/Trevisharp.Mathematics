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

    private static Variable _y = null;
    public static Variable y
    {
        get
        {
            if (_y == null)
                _y = new Variable("y");
            return _y;
        }
    }

    private static Variable _z = null;
    public static Variable z
    {
        get
        {
            if (_z == null)
                _z = new Variable("z");
            return _z;
        }
    }
}