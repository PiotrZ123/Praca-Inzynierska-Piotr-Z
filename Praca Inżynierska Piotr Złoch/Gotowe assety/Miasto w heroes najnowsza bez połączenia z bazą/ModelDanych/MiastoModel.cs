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
    [Table("Miasta")]
    public class MiastoModel : MiastoBazowyModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        
        public BohaterModel BohaterWMiescie { get; set; }
      
        List<JednostkaModel> JednostkaDoRekrutacji { get; set; }

        public List<BudynekModel> Budynki { get; set; }

        public MiastoModel()
        {
            JednostkaDoRekrutacji = new List<JednostkaModel>();
            Budynki = new List<BudynekModel>();
        }
    }
}
