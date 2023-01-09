using BenchmarkDotNet.Attributes;

namespace CollectionsBigO;

public class ListBenchmarks
{
    [Params(1000, 5000, 25000, 125000, 625000)]
    public int Size;
    private List<int>? _data;

    [IterationSetup]
    public void Setup()
    {
        _data = Enumerable.Range(0, Size).ToList();
    }

    [Benchmark]
    public void Add() => _data?.Add(new Random().Next());

    [IterationCleanup]
    public void IterationCleanup() => _data = null;
}
