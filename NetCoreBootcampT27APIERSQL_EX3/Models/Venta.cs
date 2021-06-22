using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX3.Models
{
    public class Venta
    {
        [Column(nameof(Models.Cajero))]
        public int CajeroId { get; set; }
        [ForeignKey(nameof(CajeroId))]
        public Cajero Cajero { get; set; }

        [Column("Maquina")]
        public int MaquinaRegistradoraId { get; set; }
        [ForeignKey(nameof(MaquinaRegistradoraId))]
        public MaquinaRegistradora MaquinaRegistradora { get; set; }

        [Column(nameof(Models.Producto))]
        public string ProductoId { get; set; }
        [ForeignKey(nameof(ProductoId))]
        public Producto Producto { get; set; }


    }
}
