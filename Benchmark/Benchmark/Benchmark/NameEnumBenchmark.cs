using Benchmark.NameEnum;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmark
{
    [MemoryDiagnoser]//Ajuda a analisar a memória
    public class NameEnumBenchmark
    {
        [Benchmark(Baseline = true)]//Baseline => trata o metodo como o base para comparar com outros
        public void NameEnumWithToString()
        {
            NameEnumWithToString validator = new NameEnumWithToString();

            validator.GetName(ColorEnum.Green);
        }

        [Benchmark]
        public void NameEnumWithNameof()
        {
            NameEnumWithNameof validator = new NameEnumWithNameof();

            validator.GetName(ColorEnum.Green);
        }
    }
}
