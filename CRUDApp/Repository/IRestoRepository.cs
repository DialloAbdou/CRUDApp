using CRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApp.Repository
{
    public interface IRestoRepository
    {
        IEnumerable<Resto> ListeRestaurant();
        Resto GetResto(int restoId);
        void UpdateResto(Resto resto);
        void AddResto(Resto resto);
    }
}
