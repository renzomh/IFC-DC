using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class CursoxProfesorBE
    {
        private int _CursoId;
        private String _Codigo;
        private String _Nombre;
        private String _ProfesorId;

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

        public String ProfesorId
        {
            get { return _ProfesorId; }
            set { _ProfesorId = value; }
        }
    }
}
