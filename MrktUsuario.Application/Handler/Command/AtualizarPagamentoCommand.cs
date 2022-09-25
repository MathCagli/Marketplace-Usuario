using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Command
{
    public class AtualizarPagamentoCommand : IRequest<AtualizarPagamentoCommandResponse>
    {
        public PagamentoOutputDto Pagamento { get; set; }
        public Guid IdUsuario { get; set; }

        public AtualizarPagamentoCommand(PagamentoOutputDto pagamento)
        {
            Pagamento = pagamento;
        }
    }

    public class AtualizarPagamentoCommandResponse
    {
        public PagamentoOutputDto Pagamento { get; set; }

        public AtualizarPagamentoCommandResponse(PagamentoOutputDto pagamento)
        {
            Pagamento = pagamento;
        }
    }
}