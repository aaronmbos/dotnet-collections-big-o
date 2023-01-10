using BenchmarkDotNet.Attributes;

namespace CollectionsBigO;

public class CapacityListBenchmarks
{
    [Params(1000, 5000, 25000, 125000, 625000)]
    public int Size;
    private List<int>? _data;

    [IterationSetup]
    public void Setup()
    {
        _data = new List<int>(Size + 10);
        _data.AddRange(Enumerable.Range(0, Size));
    }

    [Benchmark]
    public void CapacityAdd() => _data?.Add(new Random().Next());

    [IterationCleanup]
    public void IterationCleanup() => _data = null;
}
