using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace CollectionsBigO
{
    public class DictionaryBenchmarks
    {
        [Params(1000, 5000, 25000, 125000, 625000)]
        public int Size;
        private Dictionary<int, int>? _data;
        private Dictionary<int, int>? _cap;

        [IterationSetup]
        public void Setup()
        {
            _data = Enumerable.Range(0, Size).ToDictionary(k => k, v => v);
            _cap = new Dictionary<int, int>(Size + 10);
            Enumerable.Range(0, Size).ToList().ForEach(i => _cap.Add(i, i));
        }

        [Benchmark]
        public void DictAdd() => _data?.Add(Size + 1, new Random().Next());

        [Benchmark]
        public void CapacityDictAdd() => _cap?.Add(Size + 1, new Random().Next());

        [IterationCleanup]
        public void IterationCleanup() => _data = null;
    }
}