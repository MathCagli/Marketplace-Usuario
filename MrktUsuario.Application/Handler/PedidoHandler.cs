using MediatR;
using MrktUsuario.Application.Handler.Command;
using MrktUsuario.Application.Handler.Query;
using MrktUsuario.Application.Service;

namespace MrktUsuario.Application.PedidoHandler
{
    public class PedidoHandler : IRequestHandler<CriarPedidoCommand, CriarPedidoCommandResponse>,
                                IRequestHandler<ListarTodosPedidosQuery, ListarTodosPedidosQueryResponse>,
                                IRequestHandler<BuscarPorIDPedidoQuery, BuscarPorIDPedidoQueryResponse>,
                                IRequestHandler<AtualizarPedidoCommand, AtualizarPedidoCommandResponse>,
                                IRequestHandler<RemoverPedidoCommand, RemoverPedidoCommandResponse>
    {
        private readonly IPedidoService _pedidoService;

        public PedidoHandler(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public async Task<CriarPedidoCommandResponse> Handle(CriarPedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._pedidoService.Criar(request.Pedido);
            return new CriarPedidoCommandResponse(result);
        }

        public async Task<ListarTodosPedidosQueryResponse> Handle(ListarTodosPedidosQuery request, CancellationToken cancellationToken)
        {
            var result = await this._pedidoService.ListarTodos();
            return new ListarTodosPedidosQueryResponse(result);
        }

        public async Task<BuscarPorIDPedidoQueryResponse> Handle(BuscarPorIDPedidoQuery request, CancellationToken cancellationToken)
        {
            var result = await this._pedidoService.BuscarPorID(request.Id);
            return new BuscarPorIDPedidoQueryResponse(result);
        }

        public async Task<AtualizarPedidoCommandResponse> Handle(AtualizarPedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._pedidoService.Atualizar(request.Pedido);
            return new AtualizarPedidoCommandResponse(result);
        }

        public async Task<RemoverPedidoCommandResponse> Handle(RemoverPedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._pedidoService.Remover(request.Id);
            return new RemoverPedidoCommandResponse(result);
        }
    }
}