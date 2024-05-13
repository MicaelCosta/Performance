using Microsoft.EntityFrameworkCore;

namespace Benchmark
{
    public class ProdutoRepository
    {
        private readonly Context _ctx;

        public ProdutoRepository(Context ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<Produto>> ListAllAsync()
        {
            return await _ctx.Set<Produto>().ToListAsync();
        }

        public async Task<List<Produto>> ListAllAsNoTrackingAsync()
        {
            return await _ctx.Set<Produto>().AsNoTracking().ToListAsync();
        }
    }
}
