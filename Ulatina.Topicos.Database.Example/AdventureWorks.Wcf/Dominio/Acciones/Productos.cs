using AdventureWorks.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Wcf.Dominio.Acciones
{
    public class Productos
    {
        private static AdventureWorks2014Entities _elContexto;

        public Productos()
        {
            _elContexto = new AdventureWorks2014Entities();
        }

        public Productos(AdventureWorks2014Entities miContexto)
        {
            _elContexto = miContexto;
        }

        public IList<AdventureWorks.Products.Model.Product> ConsultarProductosPorColor(string elColor)
        {

            var laValidacion = new Validaciones.Productos();
            if (laValidacion.ElParametroNoVieneEnVacio (elColor))
            {
                // haga la consulta en la base de datos
                var elRepositorio = new Repositorio.Productos(_elContexto);
                var elResultado = elRepositorio.ConsultarProductosPorColorSinInclude(elColor);
                return elResultado;
            }
            else
            {
                throw new Exception("El parámetro 'Color' no puede venir en vacío.");
            }
        }

    }
}