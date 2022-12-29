namespace Trevisharp.Mathematics.Calculus;

using static Functions;

public record ConstantFunction : Function
{
    internal double constant;

    internal ConstantFunction(double constant)
        => this.constant = constant;

    public override double this[double x]
        => constant;

    public override Function Derive()
        => 0;

    public override Function Integrate()
        => x;
    
    protected override string Show()
        => constant.ToString();
}
