using MediatR;

namespace MrktUsuario.Application.Handler.Command
{
    public class RemoverPagamentoCommand : IRequest<RemoverPagamentoCommandResponse>
    {
        public string Id { get; set; }
    }

    public class RemoverPagamentoCommandResponse
    {
        public string Id { get; set; }

        public RemoverPagamentoCommandResponse(string id)
        {
            Id = id;
        }
    }
}