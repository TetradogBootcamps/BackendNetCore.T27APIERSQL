using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX4.Models
{
    public class Facultad
    {
        [Column("Codigo")]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}
