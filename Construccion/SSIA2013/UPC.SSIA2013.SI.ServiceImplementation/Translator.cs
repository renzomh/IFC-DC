using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

using UPC.SSIA2013.SI.ServiceContract;
using UPC.SSIA2013.SI.DataContracts;
using UPC.SSIA2013.BL.BE;
using UPC.SSIA2013.BL.BC;

namespace UPC.SSIA2013.SI.ServiceImplementation
{
    public static class Translator
    {
        public static CarreraDC fromCarreraBEtoCarreraDC(CarreraBE objBE)
        {
            CarreraDC objDC = new CarreraDC();
            objDC.CarreraId = objBE.CarreraId;
            objDC.Nombre = objBE.Nombre;
            return objDC;
        }
        public static CarreraCollectionDC fromCarreraListtoCarreraCollection(List<CarreraBE> lstBE)
        {
            CarreraCollectionDC collection = new CarreraCollectionDC();
            collection.lstCarrera = new Collection<CarreraDC>();
            for(int i=0;i<lstBE.Count;i++)
                collection.lstCarrera.Add(fromCarreraBEtoCarreraDC(lstBE[i]));
            return collection;
        }
        public static PeriodoDC fromPeriodoBEtoPeriodoDC(PeriodoBE objBE)
        {
            PeriodoDC objDC = new PeriodoDC();
            objDC.PeriodoId= objBE.PeriodoId;
            objDC.Descripcion = objBE.Descripcion;
            return objDC;
        }
        public static PeriodoCollectionDC fromPeriodoListtoPeriodoCollection(List<PeriodoBE> lstBE)
        {
            PeriodoCollectionDC collection = new PeriodoCollectionDC();
            collection.lstPeriodo = new Collection<PeriodoDC>();
            for (int i = 0; i < lstBE.Count; i++)
                collection.lstPeriodo.Add(fromPeriodoBEtoPeriodoDC(lstBE[i]));
            return collection;
        }
        public static CursoDC fromCursoBEtoCursoDC(CursoBE objBE)
        {
            CursoDC objDC = new CursoDC();
            objDC.CursoId = objBE.CursoId;
            objDC.CodigoCurso = objBE.CodigoCurso;
            objDC.Creditos = objBE.Creditos;
            objDC.EsControl = objBE.EsControl;
            objDC.EsVerificacion = objBE.EsVerificacion;
            objDC.NombreCurso = objBE.NombreCurso;
            return objDC;
        }
        public static CursoCollectionDC fromCursoListtoCursoCollection(List<CursoBE> lstBE)
        {
            CursoCollectionDC collection = new CursoCollectionDC();
            collection.lstCurso = new Collection<CursoDC>();
            for (int i = 0; i < lstBE.Count; i++)
                collection.lstCurso.Add(fromCursoBEtoCursoDC(lstBE[i]));
            return collection;
        }
        public static CursoBE fromCursoDCtoCursoBE(CursoDC objDC)
        {
            CursoBE objBE = new CursoBE();
            objBE.CursoId = objDC.CursoId;
            objBE.CodigoCurso = objDC.CodigoCurso;
            objBE.Creditos = objDC.Creditos;
            objBE.EsControl = objDC.EsControl;
            objBE.EsVerificacion = objDC.EsVerificacion;
            objBE.NombreCurso = objDC.NombreCurso;
            return objBE;
        }
    }
}
