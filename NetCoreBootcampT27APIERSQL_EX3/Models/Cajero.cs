using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX3.Models
{
    public class Cajero
    {
        [Column("Codigo")]
        public int Id { get; set; }
        [Column("NomApels")]
        [MaxLength(255)]
        public string NombreCompleto { get; set; }
    }
}
