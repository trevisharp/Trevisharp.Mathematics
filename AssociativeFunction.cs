namespace Trevisharp.Mathematics;

public record AssociativeFunction : Function
{
    public override double this[double x] => throw new System.NotImplementedException();

    public override Function Derive()
    {
        throw new System.NotImplementedException();
    }

    public override Function Integrate()
    {
        throw new System.NotImplementedException();
    }

    protected override string Show()
    {
        throw new System.NotImplementedException();
    }
}