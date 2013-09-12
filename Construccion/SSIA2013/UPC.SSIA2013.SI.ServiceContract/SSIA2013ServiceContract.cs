using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

using UPC.SSIA2013.SI.DataContracts;

namespace UPC.SSIA2013.SI.ServiceContract
{
    [ServiceContract]
    public interface SSIA2013ServiceContract
    {
        [OperationContract]
        CarreraCollectionDC CarreraListar();
        [OperationContract]
        PeriodoCollectionDC PeriodoListar();
        [OperationContract]
        CursoCollectionDC ListarCursoXPeriodoXCarrera(Parametro param);
        [OperationContract]
        bool GuardarCurso(CursoDC objCursoDC);
    }
}
