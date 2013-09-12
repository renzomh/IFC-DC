using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.SSIA2013.SI.DataContracts
{
    public class AccionMejoraDC
    {
        private Int32 _AccionMejoraId;

        public Int32 AccionMejoraId
        {
            get { return _AccionMejoraId; }
            set { _AccionMejoraId = value; }
        }

        private Int32 _HallazgoId;

        public Int32 HallazgoId
        {
            get { return _HallazgoId; }
            set { _HallazgoId = value; }
        }

        private Int32 _InformeFinCicloId;

        public Int32 InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private String _Descripcion;

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
    }
}
