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
    [Table("Bohaterowie")]
    public class BohaterModel : BohaterBazowyModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public BohaterModel()
        {
            Jednostki = new List<JednostkaModel>();
        }
        

        public List<JednostkaModel> Jednostki { get; set; }
    }
}
