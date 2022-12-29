using System;
using System.Globalization;
using System.Text;

namespace Trevisharp.Mathematics.Matrices;

public abstract class Mat
{
    public abstract int N { get; }
    public abstract int M { get; }

    static Mat()
    {
        emptyMat = new Concret2DMat(0, 0, null, true);
    }

    private static Mat emptyMat;
    /// <summary>
    /// Uma matriz vazia de tamanho qualquer.
    /// </summary>
    public static Mat Empty => emptyMat;

    public float this[int i, int j]
    {
        get => Get(i, j);
        set => Set(i, j, value);
    }

    /// <summary>
    /// Cria uma nova matriz de 2 dimensões
    /// </summary>
    /// <param name="N">Largura da matriz</param>
    /// <param name="values">Valores da matriz, precisa ser múltiplo de N.</param>
    /// <returns>Retorna a matriz criada</returns>
    public static Mat New(int N, params float[] values)
    {
        if (values.Length % N != 0 || N < 1)
            throw new InvalidOperationException();

        var mat = new Concret2DMat(N, values.Length / N, values, false);
        return mat;
    }

    protected abstract float Get(int i, int j);
    protected abstract void Set(int i, int j, float value);
    protected abstract Mat Multiply(Mat B);
    protected abstract Mat Multiply(float a);
    protected abstract Mat Sum(Mat B);
    protected abstract Mat Sub(Mat B);
    protected virtual bool Compare(Mat B)
    {
        if (this.N != B.N && this.M != B.M)
            return false;
        
        for (int j = 0; j < M; j++)
        {
            for (int i = 0; i < N; i++)
            {
                if (this[i, j] != B[i, j])
                    return false;
            }
        }
        return true;
    }
    protected virtual string Textfy()
    {
        StringBuilder sb = new StringBuilder();
        NumberFormatInfo nfi = new NumberFormatInfo();

        for (int j = 0; j < M; j++)
        {
            if (j == 0)
                sb.Append("┌");
            else if (j == M - 1)
                sb.Append("└");
            else sb.Append("│");
            for (int i = 0; i < N; i++)
            {
                sb.Append(" ");
                sb.Append(this[i, j].ToString("e2"));
            }
            if (j == 0)
                sb.Append(" ┐");
            else if (j == M - 1)
                sb.Append("┘");
            else sb.Append(" │");
        }

        return sb.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj is Mat mat)
            return this.Compare(mat);
        return false;
    }
    public override string ToString()
        => Textfy();

    public static implicit operator Mat(float[] arr)
        => new Concret2DMat(arr.Length, 1, arr, false);
    public static implicit operator Mat((float, float) t)
        => new Concret2DMat(2, 1, new float[]{ t.Item1, t.Item2 }, false);
    public static implicit operator Mat((float, float, float) t)
        => new Concret2DMat(2, 1, new float[]{ t.Item1, t.Item2 }, false);

    public static Mat operator +(Mat A, Mat B) => A.Sum(B);
    public static Mat operator -(Mat A, Mat B) => A.Sub(B);
    public static Mat operator *(Mat A, Mat B) => A.Multiply(B);
    public static Mat operator *(Mat A, float a) => A.Multiply(a);
    public static Mat operator *(float a, Mat A) => A.Multiply(a);
    public static bool operator ==(Mat A, Mat B) => A.Compare(B);
    public static bool operator !=(Mat A, Mat B) => !A.Compare(B);
}