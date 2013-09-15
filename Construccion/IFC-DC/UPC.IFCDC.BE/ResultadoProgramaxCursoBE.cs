using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class ResultadoProgramaxCursoBE
    {
        private Int32 _ResultadoProgramaId;
        private Int32 _CarreraId;
        private String _Outcome;
        private String _Descricpion;
        private Int32 _CursoId;

        public Int32 ResultadoProgramaId
        {
            get { return _ResultadoProgramaId; }
            set { _ResultadoProgramaId = value; }
        }

        public Int32 CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        public String Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; }
        }

        public String Descricpion
        {
            get { return _Descricpion; }
            set { _Descricpion = value; }
        }

        public Int32 CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }
    }
}
