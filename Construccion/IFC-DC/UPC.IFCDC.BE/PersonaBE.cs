using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class PersonaBE
    {
        private String _PersonaId;
        private String _Nombres;
        private String _Apellidos;
        private int _TipoPersona;

        public String PersonaId
        {
            get { return _PersonaId; }
            set { _PersonaId = value; }
        }
       
        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
       
        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
       
        public int TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }
    }
}
