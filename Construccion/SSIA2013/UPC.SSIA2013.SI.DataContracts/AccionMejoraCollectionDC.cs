using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.SI.DataContracts
{
    public class AccionMejoraCollectionDC
    {
        private Collection<AccionMejoraDC> _lstAccionesMejora;

        public Collection<AccionMejoraDC> LstAccionesMejora
        {
            get { return _lstAccionesMejora; }
            set { _lstAccionesMejora = value; }
        }
    }
}
