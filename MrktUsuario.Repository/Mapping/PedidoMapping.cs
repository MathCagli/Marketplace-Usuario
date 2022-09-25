using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MrktUsuario.Domain.Models;

namespace MrktUsuario.Repository.Mapping
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataAtualizacao);
            builder.Property(x => x.ValorTotal).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}