using AdventureWorks.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Wcf.Dominio.Especificaciones
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

        public IList<Product> ConsultarProductosPorColor(string elColor)
        {
            var laAccion = new Dominio.Acciones.Productos(_elContexto);
            var elResultado = laAccion.ConsultarProductosPorColor(elColor);
            return elResultado;
        }

    }
}