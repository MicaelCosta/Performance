namespace Benchmark
{
    public class ListWithTracking
    {
        private ProdutoRepository _produtoRepository;

        public ListWithTracking(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> List()
        {
            return _produtoRepository.ListAllAsNoTrackingAsync().Result;
        }
    }
}
