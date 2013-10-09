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
    public class InformeFinCicloReporteCollectionDC
    {
        [DataMember]
        private Collection<InformeFinCicloReporteDC> _lstInformeFinCicloReporte;

        public Collection<InformeFinCicloReporteDC> LstInformeFinCicloReporte
        {
            get { return _lstInformeFinCicloReporte; }
            set { _lstInformeFinCicloReporte = value; }
        }
    }
}
