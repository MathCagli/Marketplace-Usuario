using MediatR;

namespace MrktUsuario.Application.Handler.Command
{
    public class RemoverPedidoCommand : IRequest<RemoverPedidoCommandResponse>
    {
        public string Id { get; set; }
    }

    public class RemoverPedidoCommandResponse
    {
        public string Id { get; set; }

        public RemoverPedidoCommandResponse(string id)
        {
            Id = id;
        }
    }
}