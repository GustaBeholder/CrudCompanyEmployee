
using CrudCompanyEmployeeApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCompanyEmployeeApi.Infrastructure.Configuration
{
    public class CompanyAddressConfiguration : IEntityTypeConfiguration<CompanyAddress>
    {
        public void Configure(EntityTypeBuilder<CompanyAddress> builder)
        {
            builder.HasKey(ca => ca.Id);
            builder.Property(ca => ca.Id).ValueGeneratedOnAdd();
            builder.Property(ca => ca.Address).HasColumnType("VARCHAR(60)");
            builder.Property(ca => ca.Number).HasColumnType("VARCHAR(6)");
            builder.Property(ca => ca.Neighborhood).HasColumnType("VARCHAR(60)");
            builder.Property(ca => ca.State).HasColumnType("CHAR(2)");
            builder.Property(ca => ca.ExtraInfo).HasColumnType("VARCHAR(100)");
            builder.Property(ca => ca.Cep).HasColumnType("VARCHAR(8)");

        }
    }
}
