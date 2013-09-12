using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    
    public class ProfesorDC 
    {
        private String _ProfesorId;

        
        public String ProfesorId
        {
            get { return _ProfesorId; }
            set { _ProfesorId = value; }
        }

        private String _Codigo;

        
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private String _Nombres;

        
        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        private String _Apellidos;

        
        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        private Boolean _EsTC;

        
        public Boolean EsTC
        {
            get { return _EsTC; }
            set { _EsTC = value; }
        }
    }
}
