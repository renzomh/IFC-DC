using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class AccionMejoraBE
    {
        private int _AccionMejoraId;

        public int AccionMejoraId
        {
            get { return _AccionMejoraId; }
            set { _AccionMejoraId = value; }
        }

        private int _HallazgoId;

        public int HallazgoId
        {
            get { return _HallazgoId; }
            set { _HallazgoId = value; }
        }

        private int _InformeFinCicloId;

        public int InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        private int _CicloEjecucionId;

        public int CicloEjecucionId
        {
            get { return _CicloEjecucionId; }
            set { _CicloEjecucionId = value; }
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private String _Descripcion;

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private String _CodigoHallazgo;

        public String CodigoHallazgo
        {
            get { return _CodigoHallazgo; }
            set { _CodigoHallazgo = value; }
        }

        private String _CicloEjecucion;

        public String CicloEjecucion
        {
            get { return _CicloEjecucion; }
            set { _CicloEjecucion = value; }
        }
    }
}
