using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class LogroBE
    {
        private Int32 _LogroId;
        private Int32? _CursoId;
        private String _Descripcion;
        private Boolean _Estado;

        public Int32 LogroId
        {
            get { return _LogroId; }
            set { _LogroId = value; }
        }

        public Int32? CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public Boolean Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
