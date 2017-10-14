using AdventureWorks.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Wcf.Dominio.Repositorio
{
    public class Productos
    {
        private static AdventureWorks2014Entities _elContexto;

        public Productos()
        {
            _elContexto = new AdventureWorks2014Entities();
        }

        internal IList<Product> ConsultarProductosPorColor(string elColor)
        {
            List<Product> elResultado = _elContexto.Products.Include("ProductModel").Include("ProductSubcategory").Include("Produ ctReviews").Include("ProductSubcategory.ProductCategory").Where(p => p.Color.Contains(elColor)).ToList();
            return elResultado;
        }

    }
}