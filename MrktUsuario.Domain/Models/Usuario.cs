using FluentValidation;
using MrktUsuario.CrossCutting.Entity;
using MrktUsuario.CrossCutting.Utils;
using MrktUsuario.Domain.Rules;
using MrktUsuario.Domain.ValueObject;

namespace MrktUsuario.Domain.Models
{
    public class Usuario : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Sexo { get; set; }
        public int Celular { get; set; }
        public string Endereco { get; set; }

        public void SetSenha()
        {
            this.Senha.Valor = SecurityUtils.HashSHA1(this.Senha.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);

        public virtual IList<Pagamento> Pagamentos { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }

    }
}