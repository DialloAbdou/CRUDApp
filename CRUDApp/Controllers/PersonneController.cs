using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApp.Models;
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

        [HttpGet]   
        public ActionResult Edit(int id)
        {
            var personne = _personneRepository.GetPersonne(id);

            return View(personne);
        }
        [HttpPost]

        public ActionResult Edit(Personne personne)
        {
            if(personne != null)
            {
                _personneRepository.UpdatePersonne(personne);

                return RedirectToAction("List");
            }
            return NotFound();
        }


      
    }
}