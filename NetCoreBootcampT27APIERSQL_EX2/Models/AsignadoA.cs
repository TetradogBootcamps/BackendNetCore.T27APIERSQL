using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX2.Models
{
    public class AsignadoA
    {
        [Column(nameof(Cientifico))]
        public string CientificoId { get; set; }
        [ForeignKey(nameof(CientificoId))]
        public Cientifico Cientifico { get; set; }
        [Column(nameof(Proyecto))]
        public string ProyectoId { get; set; }
        [ForeignKey(nameof(ProyectoId))]
        public Proyecto Proyecto { get; set; }
    }
}
