using CRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Repository
{
   public interface IPersonneRepository
   {
         IEnumerable<Personne> GetAllPersonne();
         Personne GetPersonne(int id);
        void UpdatePersonne(Personne p);


   
   }
}
