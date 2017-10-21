using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Products.Model
{
    public partial class Product
    {
        // TODO
        // Tarea moral:
        // cree propiedades para convertir las unidades de peso de gramos o libras a ONZAS

        private double CentimetersToInchesFactor = 0.393701;

        [DataMember]
        public string SizeInInchesToPrint
        {
            get {
                var resultado = string.Empty;
                if (SizeUnitMeasureCode == null)
                {
                    if (Size != null)
                    {
                        resultado = Size;
                    }
                }
                else
                {
                    if (SizeUnitMeasureCode == "CM")
                    {
                        double sizeInDouble;
                        if (double.TryParse(Size, out sizeInDouble))
                        {
                            double sizeInInches = Math.Round(sizeInDouble * CentimetersToInchesFactor, 1);
                            resultado = string.Format("{0} {1}", sizeInInches.ToString(), "IN");
                        }
                    }
                    else
                    {
                        resultado = string.Format("{0} {1}", Size.ToString(), SizeUnitMeasureCode);
                    }
                }
                return resultado; }
        }

    }
}
