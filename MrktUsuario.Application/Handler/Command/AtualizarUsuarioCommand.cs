using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Command
{
    public class AtualizarUsuarioCommand : IRequest<AtualizarUsuarioCommandResponse>
    {
        public UsuarioOutputDto Usuario { get; set; }

        public AtualizarUsuarioCommand(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }

    public class AtualizarUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public AtualizarUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}