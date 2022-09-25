using MrktUsuario.CrossCutting.Repository;
using MrktUsuario.Domain.Models;

namespace MrktUsuario.Domain.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
    }
}