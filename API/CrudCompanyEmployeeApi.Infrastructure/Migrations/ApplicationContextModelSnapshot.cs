﻿// <auto-generated />
using CrudCompanyEmployeeApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudCompanyEmployeeApi.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("CrudCompanyEmployeeApi.Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtraInfo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Company", (string)null);
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
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
