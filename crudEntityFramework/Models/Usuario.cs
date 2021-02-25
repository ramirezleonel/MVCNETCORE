using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace crudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El celular es requerido")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El Email es requerido")]
        public string Email { get; set; }
    }
}
