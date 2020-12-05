using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }
        public virtual Resto Resto { get; set; }
        public virtual Personne Personne { get; set; }
    }
}
