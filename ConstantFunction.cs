using System;

namespace Trevisharp.Mathematics;

public record ConstantFunction : Function
{
    private double constant;

    internal ConstantFunction(double constant)
        => this.constant = constant;

    public override double this[double x]
        => constant;

    public override Function Derive()
        => 0;

    public override Function Integrate()
    {
        throw new NotImplementedException();
    }

    protected override string Show()
        => constant.ToString();
}
