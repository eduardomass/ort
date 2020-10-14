using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Servidor.Models
{
    public class UsuarioLogin
    {
        [Display(Name = "User Name just because")]
        public string Nombre { get; set; }
        public string Password  { get; set; }
    }
}