namespace Trevisharp.Mathematics;

public abstract record Function
{
    public abstract double this[double x] { get; }
    public abstract Function Derive();
    public abstract Function Integrate();
    protected abstract string Show();

    public virtual double Integrate(double a, double b)
    {
        var F = Integrate();
        return F[b] - F[a];
    }

    public override string ToString() => Show();

    public static implicit operator Function(double x)
        => new ConstantFunction(x);

    public static implicit operator Function(float x)
        => new ConstantFunction(x);

    public static implicit operator Function(int x)
        => new ConstantFunction(x);
}
