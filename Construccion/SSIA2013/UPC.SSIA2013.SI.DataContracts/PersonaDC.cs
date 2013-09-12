using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    public class PersonaDC
    {
        private String _PersonaId;


        public String PersonaId
        {
            get { return _PersonaId; }
            set { _PersonaId = value; }
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

        private int _TipoPersona;


        public int TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }
    }
}
