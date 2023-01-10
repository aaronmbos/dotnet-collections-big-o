using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace CollectionsBigO
{
    public class ListFindBenchmarks
    {
        [Params(1000, 5000, 25000, 125000, 625000)]
        public int Size;
        private List<int>? _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = new List<int>(Enumerable.Range(0, Size));
        }

        [Benchmark]
        public void Find() => _data?.Find(i => i == Size - 1);
    }
}