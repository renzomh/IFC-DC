using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class AccionMejoraCollectionBE
    {
        private Collection<AccionMejoraBE> _lstAccionesMejora;

        public Collection<AccionMejoraBE> LstAccionesMejora
        {
            get { return _lstAccionesMejora; }
            set { _lstAccionesMejora = value; }
        }
    }
}
