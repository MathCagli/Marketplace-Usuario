using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Command
{
    public class CriarPagamentoCommand : IRequest<CriarPagamentoCommandResponse>
    {
        public PagamentoInputDto Pagamento { get; set; }
        public Guid IdUsuario { get; set; }

        public CriarPagamentoCommand(PagamentoInputDto pagamento)
        {
            Pagamento = pagamento;
        }
    }

    public class CriarPagamentoCommandResponse
    {
        public PagamentoOutputDto Pagamento { get; set; }

        public CriarPagamentoCommandResponse(PagamentoOutputDto pagamento)
        {
            Pagamento = pagamento;
        }
    }
}