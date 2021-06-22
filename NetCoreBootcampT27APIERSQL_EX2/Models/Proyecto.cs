﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX2.Models
{
    public class Proyecto
    {
        [MaxLength(4)]
        public string Id { get; set; }
        [MaxLength(255)]
        public string Nombre { get; set; }
        public int Horas { get; set; }
    }
}
