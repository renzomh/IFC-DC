using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]   
    public class HallazgoDC
    {
        private int _HallazgoId;

        [DataMember]
        public int HallazgoId
        {
            get { return _HallazgoId; }
            set { _HallazgoId = value; }
        }

        private int _InformeFinCicloId;

        [DataMember]
        public int InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        private String _Codigo;

        [DataMember]
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private String _Descripcion;

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        private int _PeriodoId;

        public int PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }
    }
}
