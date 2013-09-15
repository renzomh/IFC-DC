using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    
    public class CursoxProfesorDC
    {
        private int _CursoId;
        private String _Codigo;
        private String _Nombre;
        private String _ProfesorId;

        public String ProfesorId
        {
            get { return _ProfesorId; }
            set { _ProfesorId = value; }
        }

        public int CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
