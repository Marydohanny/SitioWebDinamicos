﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("RolFormularios")]
   public class RolFormularios
    {
        [Key]
        public int IdRolFormulario { get; set; }

        [Required]
        public int IdRol { get; set; }

        [Required]
        public int IdFormulario { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int IdUsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        public int? IdUsuarioActualiza { get; set; }

        public DateTime? FechaActualizacion { get; set; }
    }
}
