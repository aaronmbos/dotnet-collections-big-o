using BenchmarkDotNet.Attributes;

namespace CollectionsBigO;

public class HashSetBenchmarks
{
    [Params(1000, 5000, 25000, 125000, 625000)]
    public int Size;

    public HashSet<int>? _data;

    [IterationSetup]
    public void Setup()
    {
        _data = new HashSet<int>(Enumerable.Range(0, Size));
    }

    [Benchmark]
    public void Remove() => _data?.Remove(Size - 1);

    [IterationCleanup]
    public void Cleanup()
    {
        _data = null;
    }
}