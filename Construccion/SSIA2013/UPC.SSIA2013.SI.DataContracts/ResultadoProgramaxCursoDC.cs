using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.SI.DataContracts
{
    
    public class ResultadoProgramaxCursoDC
    {
        private Int32 _ResultadoProgramaId;

        
        public Int32 ResultadoProgramaId
        {
            get { return _ResultadoProgramaId; }
            set { _ResultadoProgramaId = value; }
        }

        private Int32 _CarreraId;

        
        public Int32 CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        private String _Outcome;

        
        public String Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; }
        }

        private String _Descricpion;

        
        public String Descricpion
        {
            get { return _Descricpion; }
            set { _Descricpion = value; }
        }

        private Int32 _CursoId;

        
        public Int32 CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }
    }
}
