using MediatR;
using MrktUsuario.Application.DTO;

namespace MrktUsuario.Application.Handler.Command
{
    public class CriarUsuarioCommand : IRequest<CriarUsuarioCommandResponse>
    {
        public UsuarioInputDto Usuario { get; set; }

        public CriarUsuarioCommand(UsuarioInputDto usuario)
        {
            Usuario = usuario;
        }
    }

    public class CriarUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public CriarUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}