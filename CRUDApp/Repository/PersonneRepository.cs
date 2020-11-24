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
        public IEnumerable<Personne> GetAllPersonne()
        {
            return _crudDbContext.Personnes;
        }

        public Personne GetPersonne(int id)
        {
            return _crudDbContext.Personnes.FirstOrDefault(p => p.PersonneId == id);

        }

      
    }
}
