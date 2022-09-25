using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Service
{
    public interface IPedidoService
    {
        Task<PedidoOutputDto> Criar(PedidoInputDto dto);
        Task<List<PedidoOutputDto>> ListarTodos();
        Task<PedidoOutputDto> BuscarPorID(string id);
        Task<PedidoOutputDto> Atualizar(PedidoOutputDto dto);
        Task<string> Remover(string id);
    }
}