using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Electiva.WcfArticulos.Especificaciones
{
    public class ArticulosPerdidos
    {
        public int IngresarArticuloPerdido(ArticuloPerdido elArticulo, IList<Foto> lasFotos)
        {
            int resultado = 0;
            // valide que al menos se incluya una foto
            // valide que la fecha de hallazgo no sea una fecha futura
            var laValidacion = new Validaciones.Articulos();

            //// VERSIÓN 1
            //if (laValidacion.SeIncluyeAlMenosUnaFoto(lasFotos) && laValidacion.LaFechaNoEsFutura(elArticulo.FechaDeHallazgo))
            //{
            //    var laAccion = new Acciones.ArticulosPerdidos();
            //    resultado = laAccion.IngresarArticuloPerdido(elArticulo, lasFotos);

            //}
            //else
            //    resultado = -1;

            //// VERSIÓN 2
            //if (laValidacion.SeIncluyeAlMenosUnaFoto(lasFotos))
            //    if (laValidacion.LaFechaNoEsFutura(elArticulo.FechaDeHallazgo))
            //    {
            //        var laAccion = new Acciones.ArticulosPerdidos();
            //        resultado = laAccion.IngresarArticuloPerdido(elArticulo, lasFotos);

            //    }
            //    else
            //        resultado = -1;
            //else
            //    resultado = -2;

            // VERSIÓN 3
            if (laValidacion.SeIncluyeAlMenosUnaFoto(lasFotos) &
                (laValidacion.LaFechaNoEsFutura(elArticulo.FechaDeHallazgo)))
                {
                    var laAccion = new Acciones.ArticulosPerdidos();
                    resultado = laAccion.IngresarArticuloPerdido(elArticulo, lasFotos);
                }
            else
                throw new Exception(laValidacion.TodosLosErroresConcatenados);

            return resultado;
        }

    }
}