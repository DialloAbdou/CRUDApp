﻿// <auto-generated />
using CRUDApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDApp.Migrations
{
    [DbContext(typeof(CrudDbContext))]
    partial class CrudDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUDApp.Model.Personne", b =>
                {
                    b.Property<int>("PersonneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodePostal")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonneId");

                    b.ToTable("Personnes");

                    b.HasData(
                        new
                        {
                            PersonneId = 1,
                            Adresse = "Allée Reaumure",
                            CodePostal = 26000,
                            Mail = "dialloabdou26@gmail.com",
                            Nom = "DIALLO",
                            Prenom = "Abdou",
                            Telephone = "06 16 43 28 73",
                            Ville = "Valence"
                        },
                        new
                        {
                            PersonneId = 2,
                            Adresse = "5C Eugene Varlin",
                            CodePostal = 93000,
                            Mail = "barryami26@gmail.com",
                            Nom = "Barry",
                            Prenom = "Aminata",
                            Telephone = "06 13 43 75 83",
                            Ville = "Montreuil"
                        },
                        new
                        {
                            PersonneId = 3,
                            Adresse = "3 martin Guemou",
                            CodePostal = 13000,
                            Mail = "alybah26@gmail.com",
                            Nom = "Bah",
                            Prenom = "Aly",
                            Telephone = "06 13 66 75 23",
                            Ville = "Marseil"
                        },
                        new
                        {
                            PersonneId = 4,
                            Adresse = "13 allée clotures",
                            CodePostal = 33000,
                            Mail = "MSow26@gmail.com",
                            Nom = "Sow",
                            Prenom = "Moussa",
                            Telephone = "06 43 53 15 73",
                            Ville = "Grenoble"
                        },
                        new
                        {
                            PersonneId = 5,
                            Adresse = "13 allée des Martirs",
                            CodePostal = 73000,
                            Mail = "Mcamara26@gmail.com",
                            Nom = "Camara",
                            Prenom = "Amara",
                            Telephone = "06 43 15 15 73",
                            Ville = "Paris"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
