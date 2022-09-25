using MrktUsuario.CrossCutting.Entity;

namespace MrktUsuario.Domain.Models
{
    public class Pagamento : Entity<Guid>
    {
        public int NumeroCartao { get; set; }
        public string NomeCartao { get; set; }
        public int FormaPagamento { get; set; }
        public int Parcelas { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataPagamento { get; set; }
        public int Status { get; set; }
    }
}