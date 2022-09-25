using MrktUsuario.Domain.Models;
using MrktUsuario.Domain.Repository;
using MrktUsuario.Repository.Context;
using MrktUsuario.Repository.Database;

namespace MrktUsuario.Repository.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MrktUsuarioContext context) : base(context)
        {
        }
    }
}