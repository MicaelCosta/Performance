using Benchmark.Strings;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmark
{
    [MemoryDiagnoser]//Ajuda a analisar a memória
    public class StringCompareBenchmark
    {
        [Benchmark(Baseline = true)]//Baseline => trata o metodo como o base para comparar com outros
        public void StringCompareWithEqual()
        {
            StringCompareWithEqual validator = new StringCompareWithEqual();

            validator.IsValid("teste", "TESTE");
        }

        [Benchmark]
        public void StringCompareWithComparison()
        {
            StringCompareWithComparison validator = new StringCompareWithComparison();

            validator.IsValid("teste", "TESTE");
        }
    }
}
