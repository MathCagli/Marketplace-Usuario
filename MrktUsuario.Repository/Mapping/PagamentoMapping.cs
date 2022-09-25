using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MrktUsuario.Domain.Models;

namespace MrktUsuario.Repository.Mapping
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroCartao).IsRequired().HasMaxLength(16);
            builder.Property(x => x.NomeCartao).IsRequired().HasMaxLength(50);
            builder.Property(x => x.FormaPagamento).IsRequired();
            builder.Property(x => x.Parcelas);
            builder.Property(x => x.ValorPago).IsRequired();
            builder.Property(x => x.DataPagamento).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}