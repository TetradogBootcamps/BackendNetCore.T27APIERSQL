using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX4.Models
{
    public class Reserva
    {
        [Column("DNI")]
        public string InvestigadorId { get; set; }
        [ForeignKey(nameof(InvestigadorId))]
        public Investigador Investigador { get; set; }

        [Column("NumSerie")]
        public string EquipoId { get; set; }
        [ForeignKey(nameof(EquipoId))]
        public Equipo Equipo { get; set; }
        public DateTime Comienzo { get; set; }
        public DateTime Fin { get; set; }

    }
}
