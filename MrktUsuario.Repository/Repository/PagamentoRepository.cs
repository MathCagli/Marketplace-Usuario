using MrktUsuario.Domain.Models;
using MrktUsuario.Domain.Repository;
using MrktUsuario.Repository.Context;
using MrktUsuario.Repository.Database;

namespace MrktUsuario.Repository.Repository
{
    public class PagamentoRepository : Repository<Pagamento>, IPagamentoRepository
    {
        public PagamentoRepository(MrktUsuarioContext context) : base(context)
        {
        }
    }
}