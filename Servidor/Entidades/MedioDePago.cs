using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor.Entidades
{
    public class MedioDePago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Usuario Usuario { get; set; }
    }
}