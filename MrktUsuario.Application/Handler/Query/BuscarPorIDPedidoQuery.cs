using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Query
{
    public class BuscarPorIDPedidoQuery : IRequest<BuscarPorIDPedidoQueryResponse>
    {
        public string Id { get; set; }
    }

    public class BuscarPorIDPedidoQueryResponse
    {
        public PedidoOutputDto Pedido { get; set; }

        public BuscarPorIDPedidoQueryResponse(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }
}