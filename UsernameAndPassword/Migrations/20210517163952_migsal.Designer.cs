﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UsernameAndPassword.Models;

namespace UsernameAndPassword.Migrations
{
    [DbContext(typeof(RegistrationContext))]
    [Migration("20210517163952_migsal")]
    partial class migsal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UsernameAndPassword.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("employeeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("employeeid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("UsernameAndPassword.Models.LoginModel", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginmodelUserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.HasIndex("LoginmodelUserName");

                    b.ToTable("Logins");

                    b.HasData(
                        new
                        {
                            UserName = "Hema",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("UsernameAndPassword.Models.Salary", b =>
                {
                    b.Property<int>("Salary_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("EmployeeSalary")
                        .HasColumnType("real");

                    b.Property<int?>("employeeid")
                        .HasColumnType("int");

                    b.HasKey("Salary_id");

                    b.HasIndex("employeeid");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("UsernameAndPassword.Models.Employee", b =>
                {
                    b.HasOne("UsernameAndPassword.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeid");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("UsernameAndPassword.Models.LoginModel", b =>
                {
                    b.HasOne("UsernameAndPassword.Models.LoginModel", "Loginmodel")
                        .WithMany()
                        .HasForeignKey("LoginmodelUserName");

                    b.Navigation("Loginmodel");
                });

            modelBuilder.Entity("UsernameAndPassword.Models.Salary", b =>
                {
                    b.HasOne("UsernameAndPassword.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeid");

                    b.Navigation("employee");
                });
#pragma warning restore 612, 618
        }
    }
}
