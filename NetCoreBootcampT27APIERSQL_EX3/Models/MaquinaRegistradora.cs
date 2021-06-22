using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX3.Models
{
    public class MaquinaRegistradora
    {
        [Column("Codigo")]
        public int Id { get; set; }
        public int Piso { get; set; }
    }
}
