using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Servidor
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Reglas.RNUsuario.AgregarUsaurio(new Entidades.Usuario()
                {
                Activo = true,
                Password = "123",
                NombreUsuario = "USUARIO",
                Nombre = "Eduardo",
                Apellido = "Mass"
            }
                );

            Reglas.RNUsuario.AgregarUsaurio(new Entidades.Usuario()
            {
                Activo = true,
                Password = "456",
                NombreUsuario = "Carlos",
                Nombre = "Carlos",
                Apellido = "Tomada"
            }
                );


            Reglas.RNUsuario.AgregarUsaurio(new Entidades.Usuario()
            {
                Activo = true,
                Password = "Pepe",
                NombreUsuario = "Pepe",
                Nombre = "Pepe",
                Apellido = "Pepe"
            }
                );

            Reglas.RNUsuario.AgregarUsaurio(new Entidades.Usuario()
            {
                Activo = true,
                Password = "Pepe",
                NombreUsuario = "Pepe",
                Nombre = "Pepe",
                Apellido = "Pepe"
            }
               );

        }
    }
}
