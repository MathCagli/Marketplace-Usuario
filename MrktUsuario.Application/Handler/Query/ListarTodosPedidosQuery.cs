using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Query
{
    public class ListarTodosPedidosQuery : IRequest<ListarTodosPedidosQueryResponse>
    {
    }

    public class ListarTodosPedidosQueryResponse
    {
        public IList<PedidoOutputDto> Pedidos { get; set; }

        public ListarTodosPedidosQueryResponse(IList<PedidoOutputDto> pedidos)
        {
            Pedidos = pedidos;
        }
    }
}
