﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEnd.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230717012122_Initial-1")]
    partial class Initial1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domains.Asesor", b =>
                {
                    b.Property<long>("Id_Asesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id_Asesor"));

                    b.Property<int>("AniosExperiencia")
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Idiomas")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id_Asesor");

                    b.ToTable("asesores");
                });

            modelBuilder.Entity("Domains.Auto", b =>
                {
                    b.Property<long>("Id_Auto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id_Auto"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("FechaReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Auto");

                    b.ToTable("autos");
                });

            modelBuilder.Entity("Domains.Cita", b =>
                {
                    b.Property<int>("Id_Cita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Cita"));

                    b.Property<long>("AsesorId_Asesor")
                        .HasColumnType("bigint");

                    b.Property<long>("AutoId_Auto")
                        .HasColumnType("bigint");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<long>("HorarioId_Horario")
                        .HasColumnType("bigint");

                    b.Property<string>("NombresCliente")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id_Cita");

                    b.HasIndex("AsesorId_Asesor");

                    b.HasIndex("AutoId_Auto");

                    b.HasIndex("HorarioId_Horario");

                    b.ToTable("citas");
                });

            modelBuilder.Entity("Domains.EstadoUsado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("FechaReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.ToTable("estadoUsado");
                });

            modelBuilder.Entity("Domains.Horario", b =>
                {
                    b.Property<long>("Id_Horario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id_Horario"));

                    b.Property<bool>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("FechaReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Horario");

                    b.ToTable("horarios");
                });

            modelBuilder.Entity("Domains.Nuevo", b =>
                {
                    b.Property<long>("Id_Nuevo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id_Nuevo"));

                    b.Property<string>("Edicion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("FechaReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<long>("Id_Auto")
                        .HasColumnType("bigint");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Nuevo");

                    b.HasIndex("Id_Auto")
                        .IsUnique();

                    b.ToTable("nuevos");
                });

            modelBuilder.Entity("Domains.Usado", b =>
                {
                    b.Property<long>("Id_Usado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id_Usado"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("EstadoUsadoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("FechaReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<long>("Id_Auto")
                        .HasColumnType("bigint");

                    b.Property<string>("NombreVendedor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id_Usado");

                    b.HasIndex("EstadoUsadoId");

                    b.HasIndex("Id_Auto")
                        .IsUnique();

                    b.ToTable("usados");
                });

            modelBuilder.Entity("Domains.Cita", b =>
                {
                    b.HasOne("Domains.Asesor", "Asesor")
                        .WithMany("Cita")
                        .HasForeignKey("AsesorId_Asesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.Auto", "Auto")
                        .WithMany("Cita")
                        .HasForeignKey("AutoId_Auto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.Horario", "Horario")
                        .WithMany("Cita")
                        .HasForeignKey("HorarioId_Horario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asesor");

                    b.Navigation("Auto");

                    b.Navigation("Horario");
                });

            modelBuilder.Entity("Domains.Nuevo", b =>
                {
                    b.HasOne("Domains.Auto", "Auto")
                        .WithOne("Nuevo")
                        .HasForeignKey("Domains.Nuevo", "Id_Auto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auto");
                });

            modelBuilder.Entity("Domains.Usado", b =>
                {
                    b.HasOne("Domains.EstadoUsado", "EstadoUsado")
                        .WithMany("Usados")
                        .HasForeignKey("EstadoUsadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.Auto", "Auto")
                        .WithOne("Usado")
                        .HasForeignKey("Domains.Usado", "Id_Auto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auto");

                    b.Navigation("EstadoUsado");
                });

            modelBuilder.Entity("Domains.Asesor", b =>
                {
                    b.Navigation("Cita");
                });

            modelBuilder.Entity("Domains.Auto", b =>
                {
                    b.Navigation("Cita");

                    b.Navigation("Nuevo");

                    b.Navigation("Usado");
                });

            modelBuilder.Entity("Domains.EstadoUsado", b =>
                {
                    b.Navigation("Usados");
                });

            modelBuilder.Entity("Domains.Horario", b =>
                {
                    b.Navigation("Cita");
                });
#pragma warning restore 612, 618
        }
    }
}
