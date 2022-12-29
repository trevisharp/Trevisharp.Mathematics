namespace Trevisharp.Mathematics.Calculus;

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
    
    public static Function operator +(Function f, Function g)
    {
        if (f == null)
            return g ?? 0;
        if (g == null)
            return f;
        AssociativeFunction af = new AssociativeFunction();
        af.Association = new MultiplyAssociation();
        af.FunctionPool.Add(f);
        af.FunctionPool.Add(g);
        return af;
    }
    
    public static Function operator *(Function f, Function g)
    {
        AssociativeFunction af = new AssociativeFunction();
        af.Association = new MultiplyAssociation();
        af.FunctionPool.Add(f);
        af.FunctionPool.Add(g);
        return af;
    }
}
