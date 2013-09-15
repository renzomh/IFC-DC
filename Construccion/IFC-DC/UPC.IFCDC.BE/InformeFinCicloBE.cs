using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class InformeFinCicloBE
    {
        private Int32 _InformeFinCicloId;
        private String _CoordinadorId;
        private Int32 _CursoId;
        private Int32 _PeriodoId;
        private String _DesarrolloUnidades;
        private String _ComentarioInfraestructura;
        private String _ComentarioAlumnos;
        private String _ComentarioDelegados;
        private String _ComentarioEncuesta;
        private String _Estado;
        private String _UltimaActualizacion;

        public Int32 InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        public String CoordinadorId
        {
            get { return _CoordinadorId; }
            set { _CoordinadorId = value; }
        }

        public Int32 CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        public Int32 PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        public String DesarrolloUnidades
        {
            get { return _DesarrolloUnidades; }
            set { _DesarrolloUnidades = value; }
        }

        public String ComentarioInfraestructura
        {
            get { return _ComentarioInfraestructura; }
            set { _ComentarioInfraestructura = value; }
        }

        public String ComentarioAlumnos
        {
            get { return _ComentarioAlumnos; }
            set { _ComentarioAlumnos = value; }
        }

        public String ComentarioDelegados
        {
            get { return _ComentarioDelegados; }
            set { _ComentarioDelegados = value; }
        }

        public String ComentarioEncuesta
        {
            get { return _ComentarioEncuesta; }
            set { _ComentarioEncuesta = value; }
        }

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public String UltimaActualizacion
        {
            get { return _UltimaActualizacion; }
            set { _UltimaActualizacion = value; }
        }
    }
}
