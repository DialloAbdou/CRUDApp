using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApp.Models;

namespace CRUDApp.Repository
{
    public class PersonneRepository : IPersonneRepository
    {
        private readonly CrudDbContext _crudDbContext;
        public PersonneRepository(CrudDbContext crudDbContext)
        {
            _crudDbContext = crudDbContext;

        }

        public void AddPersonne(Personne p)
        {
            var id = _crudDbContext.Personnes.Max(p => p.PersonneId);
            var personne = new Personne
            {
                PersonneId = id + 1,
                Nom = p.Nom,
                Prenom = p.Prenom,
                Adresse = p.Adresse,
                CodePostal = p.CodePostal,
                Ville = p.Ville,
                Mail = p.Mail,
                Telephone = p.Telephone
            };
            _crudDbContext.Add(personne);
            _crudDbContext.SaveChanges();
        }

        public IEnumerable<Personne> GetAllPersonne()
        {
            return _crudDbContext.Personnes;
        }

        public Personne GetPersonne(int? pId)
        {
            return _crudDbContext.Personnes.FirstOrDefault(p => p.PersonneId == pId);
        }


        public void UpdatePersonne(Personne p)
        {
            var personne = _crudDbContext.Personnes.FirstOrDefault(pers => pers.PersonneId == p.PersonneId);
            if (personne != null)
            {
                personne.Nom = p.Nom;
                personne.Prenom = p.Prenom;
                personne.Adresse = p.Adresse;
                personne.CodePostal = p.CodePostal;
                personne.Ville = p.Ville;
                personne.Telephone = p.Telephone;
                personne.Mail = p.Mail;
            }
            _crudDbContext.SaveChanges();

        }

    }
}
