﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoP.WebApi.Data;

namespace ProjetoP.WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoP.WebApi.Model.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Desenvolvedora");

                    b.Property<string>("Genero");

                    b.Property<string>("Plataforma");

                    b.Property<string>("Publicadora");

                    b.Property<string>("SuporteMultijogador");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Jogo");
                });
#pragma warning restore 612, 618
        }
    }
}
