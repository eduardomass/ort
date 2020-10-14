using Servidor.Entidades;
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

            if (Reglas.RNUsuario.Buscar().Count == 0)
            {
                List<MedioDePago> listaMedioPago = new List<MedioDePago>();
                listaMedioPago.Add(new MedioDePago()
                {
                    Descripcion = "VISA"
                });
                Reglas.RNUsuario.AgregarUsaurio(new Entidades.Usuario()
                {
                    Activo = true,
                    Password = "123",
                    NombreUsuario = "USUARIO",
                    Nombre = "Eduardo",
                    Apellido = "Mass",
                    MediosDePago = listaMedioPago
                }
                );
            }
        }
    }
}
