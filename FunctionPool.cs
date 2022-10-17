using System.Collections;
using System.Collections.Generic;

namespace Trevisharp.Mathematics;

public class FunctionPool : IEnumerable<Function>
{
    private List<Function> others = new List<Function>();

    public void Add(Function f)
    {
        others.Add(f);
    }

    public IEnumerator<Function> GetEnumerator()
    {
        foreach (var f in others)
            yield return f;
    }

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}
