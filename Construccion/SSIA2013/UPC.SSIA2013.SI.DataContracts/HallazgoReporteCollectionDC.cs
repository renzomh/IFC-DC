using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class HallazgoReporteCollectionDC
    {
        [DataMember]
        private Collection<HallazgoReporteDC> _lstHallazgoReporte;

        public Collection<HallazgoReporteDC> LstHallazgoReporte
        {
            get { return _lstHallazgoReporte; }
            set { _lstHallazgoReporte = value; }
        }
    }
}
