using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AdventureWorks.Tests
{
    [TestClass]
    public class Products
    {
        [TestMethod]
        public void ListarProductosNegros()
        {
            // variables de valores esperados aka preparación del escenario
            var elColor = "Black";
            IList<AdventureWorks.Products.Model.Product> elResultadoActual;
            var laAccion = new AdventureWorks.Wcf.Dominio.Acciones.Productos();

            // invocación al método correspondiente
            elResultadoActual = laAccion.ConsultarProductosPorColor(elColor);

            // comparación
            Assert.IsNotNull(elResultadoActual);
            Assert.IsTrue(elResultadoActual.Count > 0);
        }
    }
}
