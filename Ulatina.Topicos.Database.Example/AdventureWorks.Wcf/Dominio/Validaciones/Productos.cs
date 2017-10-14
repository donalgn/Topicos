using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Wcf.Dominio.Validaciones
{
    public class Productos
    {
        public bool ElParametroNoVieneEnVacio (string elParametro)
        {
            return (elParametro != string.Empty);
        }
    }
}