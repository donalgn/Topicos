using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.Electiva.WcfArticulos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IArticulosPerdidos
    {

        [OperationContract]
        int IngresarArticuloPerdido(ArticuloPerdido elArticulo, IList<Foto> lasFotos);

        [OperationContract]
        string GetData(int elValor);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    [DataContract]
    public class ArticuloPerdido
    {
        [DataMember]
        public int IdArticulo;
        [DataMember]
        public DateTime FechaDeIngreso;
        [DataMember]
        public string UbicacionDondeSeEncontro;
        [DataMember]
        public DateTime FechaDeHallazgo;
        [DataMember]
        public MiColor Elcolor;
        [DataMember]
        public string Senas;
        [DataMember]
        public string Marca;
    }

    [DataContract]
    public class Foto
    {
        [DataMember]
        public int IdFoto;
        [DataMember]
        public int IdArticulo;
        [DataMember]
        public byte[] LaFoto;
    }

    [DataContract]
    public enum MiColor
    {
        Verde = 1,
        Azul = 2,
        Negro = 3,
        Blanco = 4,
        Amarillo = 5
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
