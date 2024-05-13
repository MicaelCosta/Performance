using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmark
{
    [MemoryDiagnoser]//Ajuda a analisar a memória
    public class ListBenchmark
    {
        private Context _context;
        private ProdutoRepository _produtoRepository;

        public ListBenchmark()
        {
            _context = new Context();
            _produtoRepository = new ProdutoRepository(_context);
        }

        [Benchmark(Baseline = true)]//Baseline => trata o metodo como o base para comparar com outros
        public void ListWithoutTracking()
        {
            new ListWithoutTracking(_produtoRepository).List();
        }

        [Benchmark]
        public void ListWithTracking()
        {
            new ListWithTracking(_produtoRepository).List();
        }
    }
}
