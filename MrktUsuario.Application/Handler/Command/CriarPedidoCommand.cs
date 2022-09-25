using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Command
{
    public class CriarPedidoCommand : IRequest<CriarPedidoCommandResponse>
    {
        public PedidoInputDto Pedido { get; set; }
        public Guid IdUsuario { get; set; }

        public CriarPedidoCommand(PedidoInputDto pedido)
        {
            Pedido = pedido;
        }
    }

    public class CriarPedidoCommandResponse
    {
        public PedidoOutputDto Pedido { get; set; }

        public CriarPedidoCommandResponse(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }
}