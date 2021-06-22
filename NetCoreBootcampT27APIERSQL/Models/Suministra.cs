using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL.Models
{
    public class Suministra
    {
        [Column("CodigoPieza")]
        public int PiezaId { get; set; }
        [ForeignKey(nameof(PiezaId))]
        public Pieza Pieza { get; set; }
        [Column("IdProveedor")]
        public string ProveedorId { get; set; }
        [ForeignKey(nameof(ProveedorId))]
        public Proveedor Proveedor { get; set; }
        public int Precio { get; set; }

    }
}
