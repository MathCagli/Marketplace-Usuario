using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Command
{
    public class AtualizarPedidoCommand : IRequest<AtualizarPedidoCommandResponse>
    {
        public PedidoOutputDto Pedido { get; set; }
        public Guid IdUsuario { get; set; }

        public AtualizarPedidoCommand(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }

    public class AtualizarPedidoCommandResponse
    {
        public PedidoOutputDto Pedido { get; set; }

        public AtualizarPedidoCommandResponse(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }
}