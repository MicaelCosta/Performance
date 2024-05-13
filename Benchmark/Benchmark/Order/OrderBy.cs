namespace Benchmark
{
    public class OrderBy
    {
        private ProdutoRepository _produtoRepository;

        public OrderBy(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> ListOrdered()
        {
            return _produtoRepository
                    .ListAllAsync()
                    .Result
                    .OrderBy(a => a.Nome)
                    .OrderBy(a => a.Preco)
                    .ToList();
        }
    }
}
