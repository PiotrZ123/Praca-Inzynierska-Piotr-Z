using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDanych
{
    [Table("Gracze")]
    public class GraczModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NumerGuid { get; set; }

        public string Imie { get; set; }
        public string Kolor { get; set; }
        public int Zloto { get; set; }
    }
}
