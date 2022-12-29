namespace Trevisharp.Mathematics.Calculus;

public record AssociativeFunction : Function
{
    private FunctionPool pool = new FunctionPool();
    public FunctionPool FunctionPool => pool;
    
    public IAssociation Association { get; set; }

    public override double this[double x]
        => Association.Calculate(pool, x);

    public override Function Derive()
        => Association.Derive(pool);

    public override Function Integrate()
        => Association.Integrate(pool);

    protected override string Show()
        => Association.Show(pool);
}
