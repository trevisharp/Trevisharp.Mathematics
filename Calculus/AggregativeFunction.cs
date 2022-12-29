namespace Trevisharp.Mathematics.Calculus;

public record AggregativeFunction : Function
{
    public Function Inner { get; set; }
    
    public IAggregation Aggregation { get; set; }

    public override double this[double x] 
        => Aggregation.Calculate(Inner, x);

    public override Function Derive()
        => Aggregation.Derive(Inner);

    public override Function Integrate()
        => Aggregation.Integrate(Inner);

    protected override string Show()
        => Aggregation.Show(Inner);
}
