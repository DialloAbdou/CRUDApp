using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Models
{
    public class Resto
    {
        [Key]
        public int RestoId { get; set; }
        [Required(ErrorMessage ="Saisir Nom Resto")]
        public string Nom { get; set; }
        [Required (ErrorMessage ="Saisir Téléphon Resto")]
        public string Telephone { get; set; }

    }
}
