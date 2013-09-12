﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using UPC.SSIA2013.SI.DataContracts;

namespace UPC.SSIA2013.SI.ServiceContracts
{
    [ServiceContract]
    public interface SSIA2013ServiceContracts
    {
        #region metodos IFC-DC

        [OperationContract]
        ResultadoProgramaxCursoCollectionDC WSListarResultadoProgramaxCurso(ResultadoProgramaxCursoDC objResultadoProgramaDC);

        [OperationContract]
        CursoxProfesorCollectionDC WSListarCursosxProfesor(CursoxProfesorDC objCursoxProfesorDC);

        [OperationContract]
        LogroDC WSListarLogroxCurso(LogroDC objLogroDC);
    
        /*
        [OperationContract]
        ProfesorDC WSObtenerProfesor(ProfesorDC objProfesorDC);

        [OperationContract]
        InformeFinCicloDC WSObtenerInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC);

        [OperationContract]
        InformeFinCicloDC WSObtenerInformeFinCicloxProfesorxCursoxPeriodo(InformeFinCicloDC objInformeFinCicloDC);

        [OperationContract]
        int WSRegistrarInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC);
        */
         
        //HALLAZGOS
        /*
        [OperationContract]
        int WSRegistrarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoCollectionDC WSListarHallazgosxInformeFinCiclo(HallazgoDC objHallazgoDC);

        [OperationContract]
        void WSEditarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        void WSEliminarHallazgo(HallazgoDC objHallazgoDC);
        */
         
        //ACCIONES DE MEJORA
        /*
        [OperationContract]
        void WSRegistrarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraCollectionDC WSListarAccionesMejoraxInformeFinCiclo(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        void WSEditarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        void WSEliminarAccionMejora(AccionMejoraDC objAccionMejoraDC);
        */
        
        //PERSONA
        [OperationContract]
        PersonaDC WSObtenerPersona(PersonaDC objPersonaDC);

        //PERIODO
        [OperationContract]
        PeriodoDC WSObtenerPeriodoActual();

        #endregion
    }
}
