using System.ComponentModel.DataAnnotations;

namespace MrktUsuario.Application.DTO
{
    public record PagamentoInputDto([Required(ErrorMessage = "Númerodo cartão é obrigatório!")] int NumeroCartao,
        [Required(ErrorMessage = "Nome do cartão é obrigatória!")] string NomeCartao,
        [Required(ErrorMessage = "Forma de pagamento é obrigatório!")] int FormaPagamento,
        int Parcelas,
        [Required(ErrorMessage = "Valor pago é obrigatório!")] decimal ValorPago,
        [Required(ErrorMessage = "Data do pagamento é obrigatório!")] DateTime DataPagamento,
        [Required(ErrorMessage = "Status é obrigatório!")] int Status);
    public record PagamentoOutputDto(Guid Id, int NumeroCartao, string NomeCartao, int FormaPagamento, int Parcelas, decimal ValorPago, DateTime DataPagamento, int Status);
}