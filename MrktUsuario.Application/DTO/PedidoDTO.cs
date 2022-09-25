using System.ComponentModel.DataAnnotations;

namespace MrktUsuario.Application.DTO
{
    public record PedidoInputDto([Required(ErrorMessage = "Data da criação é obrigatória!")] DateTime DataCriacao,
        DateTime DataAtualizacao,
        [Required(ErrorMessage = "Valor total é obrigatório!")] decimal ValorTotal,
        [Required(ErrorMessage = "Status é obrigatório!")] int Status);
    public record PedidoOutputDto(Guid Id, DateTime DataCriacao, DateTime DataAtualizacao, decimal ValorTotal, int Status);
}