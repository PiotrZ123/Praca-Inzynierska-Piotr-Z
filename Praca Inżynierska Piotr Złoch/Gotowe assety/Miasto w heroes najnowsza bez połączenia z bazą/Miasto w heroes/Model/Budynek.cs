using ModelDanych.Bazowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Model
{
    public class Budynek : BudynekBazowyModel
    {
        public Budynek()
        {
            Poziom = 0;
            Cena = 0;
        }
        public int Id { get; set; }
    }
}
