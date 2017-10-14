using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Wcf.Dominio.Especificaciones
{
    public class Productos
    {
        public IList<AdventureWorks.Products.Model.Product> ConsultarProductosPorColor(string elColor)
        {
            var laAccion = new Dominio.Acciones.Productos();
            var elResultado = laAccion.ConsultarProductosPorColor(elColor);
            return elResultado;
        }

    }
}