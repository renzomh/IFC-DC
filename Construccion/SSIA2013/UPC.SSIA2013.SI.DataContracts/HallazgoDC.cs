using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    
    public class HallazgoDC
    {
        private Int32 _HallazgoId;
        private Int32? _InformeFinCicloId;
        private String _Codigo;
        private String _Descripcion;

        public Int32 HallazgoId
        {
            get { return _HallazgoId; }
            set { _HallazgoId = value; }
        }

        
        public Int32? InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
    }
}
