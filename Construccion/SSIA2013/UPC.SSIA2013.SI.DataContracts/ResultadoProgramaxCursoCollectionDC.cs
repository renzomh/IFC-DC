using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.SI.DataContracts
{
    public class ResultadoProgramaxCursoCollectionDC
    {
        private Collection<ResultadoProgramaxCursoDC> _lstResultadoProgramaxCurso;

        public Collection<ResultadoProgramaxCursoDC> LstResultadoProgramaxCurso
        {
            get { return _lstResultadoProgramaxCurso; }
            set { _lstResultadoProgramaxCurso = value; }
        }
    }
}
