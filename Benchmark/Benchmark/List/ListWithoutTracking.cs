namespace Benchmark
{
    public class ListWithoutTracking
    {
        private ProdutoRepository _produtoRepository;

        public ListWithoutTracking(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> List()
        {
            return _produtoRepository.ListAllAsync().Result;
        }
    }
}
