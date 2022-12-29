namespace Trevisharp.Mathematics.Matrices;

public class Concret2DMat : Mat
{
    private int n;
    public override int N => n;

    private int m;
    public override int M => m;

    private float[] mat = null;
    private bool empty = false;

    internal Concret2DMat(int n, int m, float[] mat, bool empty)
    {
        this.n = n;
        this.m = m;
        this.mat = mat;
        this.empty = empty;
    }

    protected override float Get(int i, int j)
        => this.mat[i + n * j];

    protected override void Set(int i, int j, float value)
        => this.mat[i + n * j] = value;

    protected override Mat Multiply(Mat B)
    {
        throw new System.NotImplementedException();
    }

    protected override Mat Multiply(float a)
    {
        throw new System.NotImplementedException();
    }

    protected override Mat Sum(Mat B)
    {
        throw new System.NotImplementedException();
    }

    protected override Mat Sub(Mat B)
    {
        throw new System.NotImplementedException();
    }

    protected override string Textfy()
    {
        if (empty)
            return "0";
        return base.Textfy();
    }
}