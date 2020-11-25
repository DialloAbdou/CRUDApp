using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApp.Repository;
using CRUDApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApp.Controllers
{
    public class PersonneController : Controller
    {
        private readonly IPersonneRepository _personneRepository;
        public PersonneController(IPersonneRepository personneRepository)
        {
            _personneRepository = personneRepository;
                
        }
        // GET: Personne
        public ActionResult List()
        {
            var personnesViewModels = new PersonneListViewModel();
            personnesViewModels.Personnes = _personneRepository.GetAllPersonne();
            return View(personnesViewModels);
        }

      
    }
}