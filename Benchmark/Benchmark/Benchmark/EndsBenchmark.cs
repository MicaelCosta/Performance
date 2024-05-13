using Benchmark.Ends;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmark
{
    [MemoryDiagnoser]//Ajuda a analisar a memória
    public class EndsBenchmark
    {
        [Benchmark(Baseline = true)]//Baseline => trata o metodo como o base para comparar com outros
        public void EndsWithString()
        {
            EndsWithString validator = new EndsWithString();

            validator.IsValid("teste/");
        }

        [Benchmark]
        public void EndsWithChar()
        {
            EndsWithChar validator = new EndsWithChar();

            validator.IsValid("teste/");
        }
    }
}
