using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Configuration;

using UPC.SSIA2013.BL.BE;
using UPC.SSIA2013.DL.DataModel;


namespace UPC.SSIA2013.DL.DALC
{
    public class CursoDALC
    {
        public List<CursoBE> ListarCursoXPeriodoXCarrera(int CarreraId, int ciclo)
        {
            SSIA2013DataContext objModel = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            List<CursoBE> lstCurso = new List<CursoBE>();
            lstCurso = (List<CursoBE>)(from curricula in objModel.Curriculas
                                       join periodo in objModel.Periodos on curricula.PeriodoInicioId equals periodo.PeriodoId
                                       join seccionxcurso in objModel.SeccionxCursos on periodo.PeriodoId equals seccionxcurso.PeriodoId
                                       join curso in objModel.Cursos on seccionxcurso.CursoId equals curso.CursoId
                                       where (periodo.PeriodoId.Equals(ciclo) && curricula.CarreraId.Equals(CarreraId))
                                       select new CursoBE(curso.CursoId, curso.Nombre, curso.Codigo, curso.Creditos, ConvertToBool(curso.CursoControl), ConvertToBool(curso.CursoVerificacion))).ToList();
            return lstCurso;
        }
        public bool GuardarCurso(CursoBE objCursoBE)
        {
            SSIA2013DataContext objModel = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            Curso objCurso = new Curso();
            objCurso.Codigo=objCursoBE.CodigoCurso;
            objCurso.Creditos = objCursoBE.Creditos;
            objCurso.Nombre=objCursoBE.NombreCurso;
            objModel.Cursos.InsertOnSubmit(objCurso);
            return true;
        }
        private bool ConvertToBool(CursoControl objControl)
        {
            if (objControl == null)
                return false;
            return true;
        }
        private bool ConvertToBool(CursoVerificacion objVerificacion)
        {
            if (objVerificacion == null)
                return false;
            return true;
        }
    }
}
