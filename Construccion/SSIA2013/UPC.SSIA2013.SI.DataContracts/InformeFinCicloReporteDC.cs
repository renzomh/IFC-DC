using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class InformeFinCicloReporteDC
    {
        [DataMember]
        private int _InformeFinCicloId;

        public int InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        [DataMember]
        private String _CodigoCurso;

        public String CodigoCurso
        {
            get { return _CodigoCurso; }
            set { _CodigoCurso = value; }
        }

        [DataMember]
        private String _NombreCurso;

        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }

        [DataMember]
        private String _NombreProfesor;

        public String NombreProfesor
        {
            get { return _NombreProfesor; }
            set { _NombreProfesor = value; }
        }

        [DataMember]
        private String _FechaActualizacion;

        public String FechaActualizacion
        {
            get { return _FechaActualizacion; }
            set { _FechaActualizacion = value; }
        }

        [DataMember]
        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        private String _Periodo;

        public String Periodo
        {
            get { return _Periodo; }
            set { _Periodo = value; }
        }
    }
}
