using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    
    public class InformeFinCicloDC
    {
        private Int32 _InformeFinCicloId;

        
        public Int32 InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        private String _ProfesorId;

        
        public String ProfesorId
        {
            get { return _ProfesorId; }
            set { _ProfesorId = value; }
        }

        private Int32 _CursoId;

        
        public Int32 CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        private Int32 _PeriodoId;

        
        public Int32 PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        private String _ComentarioInfraestructura;

        
        public String ComentarioInfraestructura
        {
            get { return _ComentarioInfraestructura; }
            set { _ComentarioInfraestructura = value; }
        }

        private String _ComentarioAlumnos;

        
        public String ComentarioAlumnos
        {
            get { return _ComentarioAlumnos; }
            set { _ComentarioAlumnos = value; }
        }

        private Int32 _CalificacionDelegado;

        
        public Int32 CalificacionDelegado
        {
            get { return _CalificacionDelegado; }
            set { _CalificacionDelegado = value; }
        }

        private String _ComentarioDelegado;

        
        public String ComentarioDelegado
        {
            get { return _ComentarioDelegado; }
            set { _ComentarioDelegado = value; }
        }

        private String _FechaIngreso;

        
        public String FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }

        private Boolean _Estado;

        
        public Boolean Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
