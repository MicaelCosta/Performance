using Benchmark.Equality;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmark
{
    [MemoryDiagnoser]//Ajuda a analisar a memória
    public class EqualityBenchmark
    {
        [Benchmark(Baseline = true)]//Baseline => trata o metodo como o base para comparar com outros
        public void EqualityWithAny()
        {
            EqualityWithAny validator = new EqualityWithAny();

            validator.IsValid(new List<int>() { 1, 2, 3, 4, 5 }, 3);
        }

        [Benchmark]
        public void EqualityWithContains()
        {
            EqualityWithContains validator = new EqualityWithContains();

            validator.IsValid(new List<int>() { 1, 2, 3, 4, 5 }, 3);
        }
    }
}
