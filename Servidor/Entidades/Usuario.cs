using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Servidor.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        [Display(Name = "Nombre cambiado desde el code behaind")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }

        public List<MedioDePago> MediosDePago { get; set; }

    }
}