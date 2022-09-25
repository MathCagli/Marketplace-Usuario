using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Query
{
    public class ListarTodosPagamentosQuery : IRequest<ListarTodosPagamentosQueryResponse>
    {
    }

    public class ListarTodosPagamentosQueryResponse
    {
        public IList<PagamentoOutputDto> Pagamentos { get; set; }

        public ListarTodosPagamentosQueryResponse(IList<PagamentoOutputDto> pagamentos)
        {
            Pagamentos = pagamentos;
        }
    }
}
