using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Wcf.Dominio.Acciones
{
    public class Productos
    {
        public IList<AdventureWorks.Products.Model.Product> ConsultarProductosPorColor(string elColor)
        {

            var laValidacion = new AdventureWorks.Wcf.Dominio.Validaciones.Productos();
            if (laValidacion.ElParametroNoVieneEnVacio (elColor))
            {
                // haga la consulta en la base de datos
                var elRepositorio = new AdventureWorks.Wcf.Dominio.Repositorio.Productos();
                var elResultado = elRepositorio.ConsultarProductosPorColor(elColor);
                return elResultado;
            }
            else
            {
                throw new Exception("El parámetro 'Color' no puede venir en vacío.");
            }
        }

    }
}