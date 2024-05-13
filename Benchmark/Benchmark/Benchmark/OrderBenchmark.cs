using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmark
{
    [MemoryDiagnoser]//Ajuda a analisar a memória
    public class OrderBenchmark
    {
        private ProdutoRepository _produtoRepository;

        public OrderBenchmark()
        {
            _produtoRepository = new ProdutoRepository(new Context());
        }

        [Benchmark(Baseline = true)]//Baseline => trata o metodo como o base para comparar com outros
        public void OrderBy()
        {
            new OrderBy(_produtoRepository).ListOrdered();
        }

        [Benchmark]
        public void ThenBy()
        {
            new ThenBy(_produtoRepository).ListOrdered();
        }
    }
}
