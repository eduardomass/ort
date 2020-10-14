using Servidor.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Servidor.Datos
{
    public class BaseDatosContext : DbContext
    {
        public BaseDatosContext() : base()
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        //public DbSet<Peluquero> Peluqueros { get; set; }
    }
}