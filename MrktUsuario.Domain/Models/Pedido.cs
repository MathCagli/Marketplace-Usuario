using MrktUsuario.CrossCutting.Entity;

namespace MrktUsuario.Domain.Models
{
    public class Pedido : Entity<Guid>
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal ValorTotal { get; set; }
        public int Status { get; set; }
    }
}