using CRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.ViewModels
{
    public class PersonneListViewModel              
    {
        public IEnumerable<Personne>Personnes { get; set; }
    }
}
