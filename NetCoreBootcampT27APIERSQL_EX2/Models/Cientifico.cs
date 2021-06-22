using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX2.Models
{
    public class Cientifico
    {
        [Key]
        [MaxLength(8)]
        [Column("DNI")]
        public string Id { get; set; }
        [Column("NomApels")]
        [MaxLength(255)]
        public string NombreCompleto { get; set; }
    }
}
