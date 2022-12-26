
using CrudCompanyEmployeeApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCompanyEmployeeApi.Infrastructure.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(nameof(Employee));
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(e => e.Salary).HasColumnType("DECIMAL(18,2)").IsRequired();
            builder.Property(e => e.Role).HasConversion<string>();

        }
    }
}
