using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class PeriodoBE
    {
        private int _PeriodoId;
        private String _Descripcion;
        private String _FechaInicio;
        private String _FechaFin;

        public int PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public String FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        public String FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }
    }
}
