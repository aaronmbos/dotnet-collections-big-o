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

    // [Benchmark]
    // public void Remove() => _data?.Remove(Size - 1);

    [Benchmark]
    public void HashSetTryGetValue() => _data?.TryGetValue(Size - 1, out int _);

    [IterationCleanup]
    public void Cleanup()
    {
        _data = null;
    }
}