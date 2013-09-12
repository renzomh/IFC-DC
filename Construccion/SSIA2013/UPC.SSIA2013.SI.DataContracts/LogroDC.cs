using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    
    public class LogroDC
    {
        private Int32 _LogroId;

        
        public Int32 LogroId
        {
            get { return _LogroId; }
            set { _LogroId = value; }
        }

        private Int32? _CursoId;

        
        public Int32? CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        private String _Descripcion;

        
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private Boolean _Estado;

        
        public Boolean Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
