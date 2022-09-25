using MediatR;
using MrktUsuario.Application.Handler.Command;
using MrktUsuario.Application.Handler.Query;
using MrktUsuario.Application.Service;

namespace MrktUsuario.Application.PagamentoHandler
{
    public class PagamentoHandler : IRequestHandler<CriarPagamentoCommand, CriarPagamentoCommandResponse>,
                                IRequestHandler<ListarTodosPagamentosQuery, ListarTodosPagamentosQueryResponse>,
                                IRequestHandler<BuscarPorIDPagamentoQuery, BuscarPorIDPagamentoQueryResponse>,
                                IRequestHandler<AtualizarPagamentoCommand, AtualizarPagamentoCommandResponse>,
                                IRequestHandler<RemoverPagamentoCommand, RemoverPagamentoCommandResponse>
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoHandler(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        public async Task<CriarPagamentoCommandResponse> Handle(CriarPagamentoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._pagamentoService.Criar(request.Pagamento);
            return new CriarPagamentoCommandResponse(result);
        }

        public async Task<ListarTodosPagamentosQueryResponse> Handle(ListarTodosPagamentosQuery request, CancellationToken cancellationToken)
        {
            var result = await this._pagamentoService.ListarTodos();
            return new ListarTodosPagamentosQueryResponse(result);
        }

        public async Task<BuscarPorIDPagamentoQueryResponse> Handle(BuscarPorIDPagamentoQuery request, CancellationToken cancellationToken)
        {
            var result = await this._pagamentoService.BuscarPorID(request.Id);
            return new BuscarPorIDPagamentoQueryResponse(result);
        }

        public async Task<AtualizarPagamentoCommandResponse> Handle(AtualizarPagamentoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._pagamentoService.Atualizar(request.Pagamento);
            return new AtualizarPagamentoCommandResponse(result);
        }

        public async Task<RemoverPagamentoCommandResponse> Handle(RemoverPagamentoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._pagamentoService.Remover(request.Id);
            return new RemoverPagamentoCommandResponse(result);
        }
    }
}