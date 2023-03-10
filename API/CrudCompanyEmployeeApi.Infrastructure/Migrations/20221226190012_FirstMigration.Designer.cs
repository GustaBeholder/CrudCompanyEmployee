// <auto-generated />
using CrudCompanyEmployeeApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudCompanyEmployeeApi.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221226190012_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("CrudCompanyEmployeeApi.Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("Id");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("CrudCompanyEmployeeApi.Domain.Entities.CompanyAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("VARCHAR(8)");

                    b.Property<string>("ExtraInfo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("VARCHAR(6)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("CHAR(2)");

                    b.HasKey("Id");

                    b.ToTable("CompanyAddress");
                });

            modelBuilder.Entity("CrudCompanyEmployeeApi.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Salary")
                        .HasColumnType("DECIMAL(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("CrudCompanyEmployeeApi.Domain.Entities.CompanyAddress", b =>
                {
                    b.HasOne("CrudCompanyEmployeeApi.Domain.Entities.Company", "Company")
                        .WithOne("Address")
                        .HasForeignKey("CrudCompanyEmployeeApi.Domain.Entities.CompanyAddress", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CrudCompanyEmployeeApi.Domain.Entities.Employee", b =>
                {
                    b.HasOne("CrudCompanyEmployeeApi.Domain.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CrudCompanyEmployeeApi.Domain.Entities.Company", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
