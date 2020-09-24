using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor.Models
{
    public class UsuarioModel
    {
        public string Nombre { get; set; }
        public List<string> Mensajes { get; set; } = new List<string>();
    }
}