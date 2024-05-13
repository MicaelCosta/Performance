namespace Benchmark
{
    public class ThenBy
    {
        private ProdutoRepository _produtoRepository;

        public ThenBy(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> ListOrdered()
        {
            return _produtoRepository
                    .ListAllAsync()
                    .Result
                    .OrderBy(a => a.Nome)
                    .ThenBy(b => b.Preco)
                    .ToList();
        }
    }
}
