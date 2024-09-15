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
    [Table("Mapy")]
    public class MapaModel : MapaBazowyModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataICzasUtorzenia { get; set; }
        public List<BohaterModel> Bohaterowie { get; set; }
        public List<MiastoModel> Miasta { get; set; }
        public List<GraczModel> Gracze { get; set; }
        
        public MapaModel()
        {
            Bohaterowie = new List<BohaterModel>();
            Miasta = new List<MiastoModel>();
            Gracze = new List<GraczModel>();
            DataICzasUtorzenia = DateTime.Now;
        }

    }
}
