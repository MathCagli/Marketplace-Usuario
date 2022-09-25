using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Query
{
    public class BuscarPorIDPagamentoQuery : IRequest<BuscarPorIDPagamentoQueryResponse>
    {
        public string Id { get; set; }
    }

    public class BuscarPorIDPagamentoQueryResponse
    {
        public PagamentoOutputDto Pagamento { get; set; }

        public BuscarPorIDPagamentoQueryResponse(PagamentoOutputDto pagamento)
        {
            Pagamento = pagamento;
        }
    }
}