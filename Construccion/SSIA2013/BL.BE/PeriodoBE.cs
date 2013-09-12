using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.SSIA2013.BL.BE
{
    public class PeriodoBE
    {
        public PeriodoBE(int periodoid,String descripcion)
        {
            this.PeriodoId = periodoid;
            this.Descripcion = descripcion;
        }

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
    }
}
