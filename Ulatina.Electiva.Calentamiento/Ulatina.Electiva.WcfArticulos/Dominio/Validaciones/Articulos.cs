using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Electiva.WcfArticulos.Validaciones
{
    public class Articulos
    {
        //private string Delimitador = Environment.NewLine;
        private string Delimitador = " | ";

        private IList <string> MisErroresPrivados;

        public IList<string> ListaDeErrores
        {
            get
            {
                return (MisErroresPrivados);
            }
        }

        public string TodosLosErroresConcatenados
        {
            get
            {
                var resultado = string.Empty;
                if (ListaDeErrores.Count > 0)
                    resultado = string.Join(Delimitador, ListaDeErrores);

                return resultado;
            }
        }

        public Articulos()
        {
            MisErroresPrivados = new List<string>();
        }

        public bool SeIncluyeAlMenosUnaFoto (IList<Foto> lasFotos)
        {
            bool elResultado = (lasFotos.Count() > 0);
            if (! elResultado)
            {
                RegistrarError("ERROR: Se debe incluir al menos una foto.");
            }
            return elResultado;
        }

        public bool LaFechaNoEsFutura (DateTime laFecha)
        {
            bool elResultado = (laFecha <= DateTime.Now);
            if (! elResultado)
            {
                RegistrarError(string.Format("ERROR: La fecha y hora [{0}] deben ser menor a las del sistema [{1}].", laFecha.ToString(), DateTime.Now.ToString()));
            }
            return elResultado;
        }

        private void RegistrarError(string elError)
        {
            MisErroresPrivados.Add(elError);
        }

    }
}