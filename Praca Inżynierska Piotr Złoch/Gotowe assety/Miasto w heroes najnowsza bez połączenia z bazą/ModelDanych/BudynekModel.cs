using ModelDanych.Bazowy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDanych
{
    [Table("Budynki")]
    public class BudynekModel : BudynekBazowyModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PolozenieWTablicy { get; set; }
    }
}
