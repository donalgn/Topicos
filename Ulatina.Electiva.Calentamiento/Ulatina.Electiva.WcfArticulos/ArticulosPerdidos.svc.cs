using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.Electiva.WcfArticulos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ArticulosPerdidos : IArticulosPerdidos
    {
        public int IngresarArticuloPerdido(ArticuloPerdido elArticulo)
        {
            // Especificaciones.ArticulosPerdidos laEspecificacion = new Especificaciones.ArticulosPerdidos();
            var laEspecificacion = new Especificaciones.ArticulosPerdidos();
            var elResultado = laEspecificacion.IngresarArticuloPerdido(elArticulo);

            return elResultado;
        }
        public string GetData(int elValor)
        {
            return string.Format("You entered: {0}", elValor);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
