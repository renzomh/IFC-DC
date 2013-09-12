using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    public class PeriodoDC
    {
        private int _PeriodoId;
        
        
        public int PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        private String _Descripcion;
                
        
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private String _FechaInicio;

        public String FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        private String _FechaFin;

        public String FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }
    }
}
