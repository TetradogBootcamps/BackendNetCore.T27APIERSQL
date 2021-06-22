using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX3.Models
{
    public class Producto
    {
        [Column("Codigo")]
        public string Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}
