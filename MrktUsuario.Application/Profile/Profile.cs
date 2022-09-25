using MrktUsuario.Application.DTO;
using MrktUsuario.Domain.Models;

namespace MrktUsuario.Application.Profile
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            // Pagamento
            CreateMap<PagamentoInputDto, Pagamento>();
            CreateMap<Pagamento, PagamentoOutputDto>();
            CreateMap<PagamentoOutputDto, Pagamento>();

            // Pagamento
            CreateMap<PedidoInputDto, Pedido>();
            CreateMap<Pedido, PedidoOutputDto>();
            CreateMap<PedidoOutputDto, Pedido>();

            // Usuário
            CreateMap<UsuarioInputDto, Usuario>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email))
                .ForPath(x => x.Senha.Valor, f => f.MapFrom(m => m.Senha));
            CreateMap<Usuario, UsuarioOutputDto>()
                .ForMember(x => x.Email, f => f.MapFrom(m => m.Email.Valor))
                .ForMember(x => x.Senha, f => f.MapFrom(m => m.Senha.Valor));
            CreateMap<UsuarioOutputDto, Usuario>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email))
                .ForPath(x => x.Senha.Valor, f => f.MapFrom(m => m.Senha));
        }
    }
}