using MrktUsuario.Domain.Models;
using MrktUsuario.Domain.Repository;
using MrktUsuario.Repository.Context;
using MrktUsuario.Repository.Database;

namespace MrktUsuario.Repository.Repository
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(MrktUsuarioContext context) : base(context)
        {
        }
    }
}