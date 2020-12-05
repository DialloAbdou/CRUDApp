using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Models
{
    public class Sondage
    {
        [Key]
        public int SondageId { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Vote> Votes { get; set; }

    }
}
