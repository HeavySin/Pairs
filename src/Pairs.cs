using System.Collections;

public class Pair<TF, TS>
{
    public TF First { get; set; }
    public TS Second { get; set; }

    public Pair(TF firstArg, TS secondArg)
    {
        First = firstArg;
        Second = secondArg;
    }
}

public class Pairs<TF, TS> : IEnumerable<Pair<TF, TS>>
{
    private readonly uint _maximumSize;
    private List<Pair<TF, TS>>? _pairs;

    public uint Capacity => _maximumSize;

    public Pairs(IEnumerable<Pair<TF, TS>> pairsArg, uint maximumSizeArg = 10000)
    {
        _maximumSize = maximumSizeArg;
        _pairs = pairsArg.ToList();
    }

    public Pairs(uint maximumSizeArg = 10000)
    {
        _maximumSize = maximumSizeArg;
        _pairs = new List<Pair<TF, TS>>();
    }

    public bool Add(TF firstArg, TS secondArg)
    {
        if (Count() >= Capacity) return false;

        _pairs?.Add(new Pair<TF, TS>(firstArg, secondArg));
        return true;
    }

    public int Count()
    {
        return _pairs?.Count ?? 0;
    }

    public IEnumerator<Pair<TF, TS>> GetEnumerator()
    {
        return _pairs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
