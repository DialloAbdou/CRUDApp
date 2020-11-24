using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Model
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options)
        {
        }
        public DbSet<Personne> Personnes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Personne>().HasData(
                new Personne
                {
                    PersonneId = 1,
                    Nom = "DIALLO",
                    Prenom = "Abdou",
                    Adresse = "Allée Reaumure",
                    CodePostal = 26000,
                    Ville = "Valence",
                    Telephone = "06 16 43 28 73",
                    Mail = "dialloabdou26@gmail.com"
                });
            modelBuilder.Entity<Personne>().HasData(
            new Personne
            {
                PersonneId = 2,
                Nom = "Barry",
                Prenom = "Aminata",
                Adresse = "5C Eugene Varlin",
                CodePostal = 93000,
                Ville = "Montreuil",
                Telephone = "06 13 43 75 83",
                Mail = "barryami26@gmail.com"
            });

            modelBuilder.Entity<Personne>().HasData(
            new Personne
            {
                PersonneId = 3,
                Nom = "Bah",
                Prenom = "Aly",
                Adresse = "3 martin Guemou",
                CodePostal = 13000,
                Ville = "Marseil",
                Telephone = "06 13 66 75 23",
                Mail = "alybah26@gmail.com"
            });

            modelBuilder.Entity<Personne>().HasData(
            new Personne
            {
                PersonneId = 4,
                Nom = "Sow",
                Prenom = "Moussa",
                Adresse = "13 allée clotures",
                CodePostal = 33000,
                Ville = "Grenoble",
                Telephone = "06 43 53 15 73",
                Mail = "MSow26@gmail.com"
            });

            modelBuilder.Entity<Personne>().HasData(
             new Personne
              {
                   PersonneId = 5,
                   Nom = "Camara",
                   Prenom = "Amara",
                   Adresse = "13 allée des Martirs",
                   CodePostal = 73000,
                   Ville = "Paris",
                   Telephone = "06 43 15 15 73",
                   Mail = "Mcamara26@gmail.com"
               });





        }
    }
}
