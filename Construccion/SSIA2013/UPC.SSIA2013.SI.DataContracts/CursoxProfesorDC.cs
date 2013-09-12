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

        
        public int CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        private String _Codigo;

        
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private String _Nombre;

        
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _ProfesorId;

        
        public string ProfesorId
        {
            get { return _ProfesorId; }
            set { _ProfesorId = value; }
        }
    }
}
