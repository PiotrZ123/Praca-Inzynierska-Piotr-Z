using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDanych
{
    [Table("Jednostki")]
    public class JednostkaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PolozenieWTablicy { get; set; }

        public string WlascicielGuid { get; set; }

        public int IdWlasciciel { get; set; }
        public int Przyrost { get; set; }
        public int Numer { get; set; }

        public int Ilosc { get; set; }

        public int Koszt { get; set; }

        public int ZycieAktualne { get; set; }

        public int Zycie_max { get; set; }
        public int Atak { get; set; }
        public int Obrona { get; set; }
        public int Obrazenia_min { get; set; }
        public int Obrazenia_max { get; set; }

        public int Kontratak { get; set; }
        public int Ilosc_strzal { get; set; }

        public int Szybkosc { get; set; }
        public bool Strzela { get; set; }

        
       
        
    }
}
