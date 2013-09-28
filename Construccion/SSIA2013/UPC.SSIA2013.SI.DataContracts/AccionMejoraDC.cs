using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class AccionMejoraDC
    {
        private int _accionMejoraId;

        [DataMember]
        public int AccionMejoraId
        {
            get { return _accionMejoraId; }
            set { _accionMejoraId = value; }
        }

        private int _hallazgoId;

        [DataMember]
        public int HallazgoId
        {
            get { return _hallazgoId; }
            set { _hallazgoId = value; }
        }

        private int _informeFinCicloId;

        [DataMember]
        public int InformeFinCicloId
        {
            get { return _informeFinCicloId; }
            set { _informeFinCicloId = value; }
        }

        private int _cicloEjecucionId;

        [DataMember]
        public int CicloEjecucionId
        {
            get { return _cicloEjecucionId; }
            set { _cicloEjecucionId = value; }
        }

        private String _codigo;

        [DataMember]
        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private String _descripcion;

        [DataMember]
        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private String _estado;

        [DataMember]
        public String Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private String _codigoHallazgo;

        [DataMember]
        public String CodigoHallazgo
        {
            get { return _codigoHallazgo; }
            set { _codigoHallazgo = value; }
        }

        private String _cicloEjecucion;

        [DataMember]
        public String CicloEjecucion
        {
            get { return _cicloEjecucion; }
            set { _cicloEjecucion = value; }
        }
    }
}
