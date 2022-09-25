using System.ComponentModel.DataAnnotations;

namespace MrktUsuario.Application.DTO
{
    public record UsuarioInputDto([Required(ErrorMessage = "Nome é obrigatório!")] string Nome, 
        [Required(ErrorMessage = "CPF é obrigatória!")] string Cpf, 
        [Required(ErrorMessage = "Email é obrigatório!")] string Email, 
        [Required(ErrorMessage = "Senha é obrigatória!")] string Senha, 
        [Required(ErrorMessage = "Sexo é obrigatório!")] string Sexo, 
        [Required(ErrorMessage = "Celular é obrigatório!")] int Celular, 
        [Required(ErrorMessage = "Endereço é obrigatório!")] string Endereco, 
        List<PagamentoInputDto> Pagamentos,
        List<PedidoInputDto> Pedidos);
    public record UsuarioOutputDto(Guid Id, string Nome, string Cpf, string Email, string Senha, string Sexo, int Celular, string Endereco);
}