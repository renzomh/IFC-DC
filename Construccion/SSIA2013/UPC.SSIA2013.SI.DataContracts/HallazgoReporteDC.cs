using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class HallazgoReporteDC
    {
        [DataMember]
        private int _HallazogId;

        public int HallazogId
        {
            get { return _HallazogId; }
            set { _HallazogId = value; }
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
        private String _NombreCurso;

        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }
    }
}
