using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Models
{
    public class Personne
    {
        [Key]
        public int PersonneId  { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
    }
}
