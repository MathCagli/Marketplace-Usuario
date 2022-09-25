using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Query
{
    public class ListarTodosUsuariosQuery : IRequest<ListarTodosUsuariosQueryResponse>
    {
    }

    public class ListarTodosUsuariosQueryResponse
    {
        public IList<UsuarioOutputDto> Usuarios { get; set; }

        public ListarTodosUsuariosQueryResponse(IList<UsuarioOutputDto> usuarios)
        {
            Usuarios = usuarios;
        }
    }
}
