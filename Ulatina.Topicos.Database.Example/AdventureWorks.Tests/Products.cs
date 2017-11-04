using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AdventureWorks.Products.Model;

namespace AdventureWorks.Tests
{
    [TestClass]
    public class Products
    {
        private static MiAdventureWorks _elContexto = new MiAdventureWorks();

        
        [TestMethod]
        public void ListarProductosNegros()
        {
            // variables de valores esperados aka preparación del escenario
            var elColor = "Black";
            IList<AdventureWorks.Products.Model.Product> elResultadoActual;
            var laAccion = new AdventureWorks.Wcf.Dominio.Acciones.Productos(_elContexto);

            // invocación al método correspondiente
            elResultadoActual = laAccion.ConsultarProductosPorColor(elColor);

            // comparación
            Assert.IsNotNull(elResultadoActual);
            Assert.IsTrue(elResultadoActual.Count > 0);
        }
    }
}
