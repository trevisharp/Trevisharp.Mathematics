namespace Trevisharp.Mathematics;

public record Variable : Function
{
    private string name;
    internal Variable(string name)
        => this.name = name;

    public override double this[double x] 
        => x;

    public override Function Derive()
        => 1;

    public override Function Integrate()
    {
        throw new System.NotImplementedException();
    }

    protected override string Show()
        => name;
}