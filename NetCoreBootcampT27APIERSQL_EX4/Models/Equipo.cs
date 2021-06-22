using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX4.Models
{
    public class Equipo
    {
        [Column("NumSerie")]
        [MaxLength(4)]
        public string Id { get; set; }
        [Column(nameof(Models.Facultad))]
        public int FacultadId { get; set; }
        [ForeignKey(nameof(FacultadId))]
        public Facultad Facultad { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}
