using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class AccionMejoraReporteDC
    {
        [DataMember]
        private int _AccionMejoraId;

        public int AccionMejoraId
        {
            get { return _AccionMejoraId; }
            set { _AccionMejoraId = value; }
        }

        [DataMember]
        private String _CodigoAccionMejora;

        public String CodigoAccionMejora
        {
            get { return _CodigoAccionMejora; }
            set { _CodigoAccionMejora = value; }
        }

        [DataMember]
        private String _CodigoHallazgo;

        public String CodigoHallazgo
        {
            get { return _CodigoHallazgo; }
            set { _CodigoHallazgo = value; }
        }

        [DataMember]
        private String _Descripcion;

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
