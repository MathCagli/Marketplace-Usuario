using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Service
{
    public interface IPagamentoService
    {
        Task<PagamentoOutputDto> Criar(PagamentoInputDto dto);
        Task<List<PagamentoOutputDto>> ListarTodos();
        Task<PagamentoOutputDto> BuscarPorID(string id);
        Task<PagamentoOutputDto> Atualizar(PagamentoOutputDto dto);
        Task<string> Remover(string id);
    }
}