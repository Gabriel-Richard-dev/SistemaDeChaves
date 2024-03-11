using IFCE.Chaves.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFCE.Chaves.Infra.Data.Mappings;

public class SolicitanteMap : IEntityTypeConfiguration<Solicitante>
{
    public void Configure(EntityTypeBuilder<Solicitante> builder)
    {
        builder.ToTable("Solicitante");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id)
            .ValueGeneratedOnAdd()
            .UseMySqlIdentityColumn()
            .HasColumnType("BIGINT");

        builder.Property(s => s.Email)
            .IsRequired()
            .HasColumnType("VARCHAR(180)");

        


    }
}