using IFCE.Chaves.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFCE.Chaves.Infra.Data.Mappings;

public class ChaveMap : IEntityTypeConfiguration<Chave>
{
    public void Configure(EntityTypeBuilder<Chave> builder)
    {
        builder.ToTable("Chave");
        
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd()
            .UseMySqlIdentityColumn()
            .HasColumnType("BIGINT");


        builder.Property(c => c.Numero)
            .IsRequired()
            .HasColumnType("BIGINT");
        
        
        builder.Property(c => c.Sala)
            .IsRequired();
        
        builder.Property(c => c.color)
            .HasDefaultValue("green");

        builder.Property(c => c.Responsavel)
            .IsRequired();

        builder.Property(c => c.isDisponivel)
            .HasDefaultValue(1)
            .HasColumnType("TINYINT");
        
    }
}