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
        public ActionResult Edit(int?  pId)
        {
            if (pId.HasValue)
            {
              var personne = _personneRepository.GetPersonne(pId);
                return View(personne);

            }

            return View();
        }
        [HttpPost]

        public ActionResult Edit(Personne personne)
        {
            if(!ModelState.IsValid)
            {
                return View(personne);
            }
            if(personne.PersonneId.HasValue)
            {
                _personneRepository.UpdatePersonne(personne);

                return RedirectToAction("List");
            }
            else
            {
                _personneRepository.AddPersonne(personne);
                return RedirectToAction("List");
            }
          
        }


      
    }
}