using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class HallazgoCollectionBE

    {
        private Collection<HallazgoBE> _lstHallazgos;

        public Collection<HallazgoBE> LstHallazgos
        {
            get { return _lstHallazgos; }
            set { _lstHallazgos = value; }
        }
    }
}
