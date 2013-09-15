using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class ResultadoProgramaxCursoCollectionBE
    {
        private Collection<ResultadoProgramaxCursoBE> _lstResultadoProgramaxCurso;

        public Collection<ResultadoProgramaxCursoBE> LstResultadoProgramaxCurso
        {
            get { return _lstResultadoProgramaxCurso; }
            set { _lstResultadoProgramaxCurso = value; }
        }
    }
}
