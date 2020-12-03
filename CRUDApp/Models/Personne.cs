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
        public int ? PersonneId  { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public int CodePostal { get; set; }
        [Required]
        public string Ville { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Telephone { get; set; }
    }
}
