using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.SI.DataContracts
{ 
    public class HallazgoCollectionDC
    {
        private Collection<HallazgoDC> _lstHallazgos;

        
        public Collection<HallazgoDC> LstHallazgos
        {
            get { return _lstHallazgos; }
            set { _lstHallazgos = value; }
        }
    }
}
