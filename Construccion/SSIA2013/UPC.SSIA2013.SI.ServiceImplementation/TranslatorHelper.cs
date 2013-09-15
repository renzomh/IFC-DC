using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

using UPC.SSIA2013.DL.DataModel;
using UPC.SSIA2013.SI.DataContracts;

namespace UPC.SSIA2013.SI.ServiceImplementation
{
    public class TranslatorHelper
    {
        private static String parseDate(DateTime? fecha)
        {
            return fecha.Value.Day + "/" + fecha.Value.Month + "/" + fecha.Value.Year + " " + fecha.Value.Hour + ":" + fecha.Value.Minute + ":" + fecha.Value.Second;
        }

        #region metodos IFC-DC
        
        //ACCIONES DE MEJORA

        /*
        public static AccionMejoraCollectionDC TranslateAccionesMejoraLRToAccionesMejoraCollection(List<spListarAccionesMejoraxHallazgoResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraDC TranslateAccionMejoraLRToAccionMejoraDC(spListarAccionesMejoraxHallazgoResult objLR)
        {
            AccionMejoraDC obj;

            try
            {
                obj = new AccionMejoraDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.HallazgoId = objLR.HallazgoId;
                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.Codigo = objLR.Codigo;
                obj.Descripcion = objLR.Descripcion;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
         
        //RESULTADO_PROGRAMA_CURSO
        public static ResultadoProgramaxCursoCollectionDC TranslateResultadoProgramasxCursoLRToResultadoProgramaCollection(List<up_IFCDC_Listar_ResultadoPrograma_x_CursoResult> lstLR)
        {
            ResultadoProgramaxCursoCollectionDC collection;

            try
            {
                collection = new ResultadoProgramaxCursoCollectionDC();
                collection.LstResultadoProgramaxCurso = new Collection<ResultadoProgramaxCursoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstResultadoProgramaxCurso.Add(TranslateHallazgoxInformeFinCicloLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ResultadoProgramaxCursoDC TranslateHallazgoxInformeFinCicloLRToHallazgoDC(up_IFCDC_Listar_ResultadoPrograma_x_CursoResult objLR)
        {
            ResultadoProgramaxCursoDC obj;

            try
            {
                obj = new ResultadoProgramaxCursoDC();

                obj.ResultadoProgramaId = objLR.ResultadoProgramaId;
                obj.CarreraId = objLR.CarreraId.Value;
                obj.Outcome  = objLR.Outcome;
                obj.Descricpion = objLR.Descripcion;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PROFESOR
        /*
        public static ProfesorDC TranslateProfesorLRToProfesorDC(spObtenerProfesorResult objLR)
        {
            ProfesorDC objProfesorDC;

            try
            {
                objProfesorDC = new ProfesorDC();

                if (objLR != null)
                {
                    objProfesorDC.ProfesorId = objLR.ProfesorId;
                    objProfesorDC.Codigo = objLR.Codigo;
                    objProfesorDC.Nombres = objLR.Nombres;
                    objProfesorDC.Apellidos = objLR.Apellidos;
                    objProfesorDC.EsTC = Boolean.Parse(objLR.EsTC.ToString());
                }  

                return objProfesorDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
         
        //PERSONA
        public static PersonaDC TranslatePersonaLRToPersonaDC(up_IFCDC_Obtener_PersonaResult objLR)
        {
            PersonaDC objPersonaDC;

            try
            {
                objPersonaDC = new PersonaDC();

                if (objLR != null)
                {
                    objPersonaDC.PersonaId = objLR.PersonaId;
                    objPersonaDC.Nombres = objLR.Nombres;
                    objPersonaDC.Apellidos = objLR.Apellidos;
                    objPersonaDC.TipoPersona = Int32.Parse(objLR.TipoPersona.ToString());
                }

                return objPersonaDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PERIODO
        public static PeriodoDC TranslatePeriodoLRToPeriodoDC(up_IFCDC_Obtener_PeriodoActualResult objLR)
        {
            PeriodoDC objPerdiodoDC;

            try
            {
                objPerdiodoDC = new PeriodoDC();
                if (objLR != null)
                {
                    objPerdiodoDC.PeriodoId = Int32.Parse(objLR.PeriodoId.ToString());
                    objPerdiodoDC.Descripcion = objLR.Descripcion;
                    objPerdiodoDC.FechaInicio = objLR.FechaInicio;
                    objPerdiodoDC.FechaFin = objLR.FechaFin;
                }
                return objPerdiodoDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //INFORME FIN CICLO
        /*
        public static InformeFinCicloDC TranslateInformeFinCicloLRToInformeFinCicloDC(spObtenerInformeFinCicloResult objLR)
        {
            InformeFinCicloDC objInformeFinCiclo;

            try
            {
                objInformeFinCiclo = new InformeFinCicloDC();

                if (objLR != null)
                {
                    objInformeFinCiclo.InformeFinCicloId = objLR.InformeFinCicloId;
                    objInformeFinCiclo.ProfesorId = objLR.ProfesorId;
                    objInformeFinCiclo.CursoId = objLR.CursoId;
                    objInformeFinCiclo.PeriodoId = objLR.PeriodoId;
                    objInformeFinCiclo.ComentarioInfraestructura = objLR.ComentarioInfraestructura;
                    objInformeFinCiclo.ComentarioAlumnos = objLR.ComentarioAlumnos;
                    objInformeFinCiclo.ComentarioDelegado = objLR.ComentarioDelegado;
                    objInformeFinCiclo.FechaIngreso = objLR.FechaIngreso.ToString();
                    if(objLR.Estado != null)
                        objInformeFinCiclo.Estado = Boolean.Parse(objLR.Estado.ToString());
                }

                return objInformeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
    
        public static InformeFinCicloDC TranslateInformeFinCicloLRToInformeFinCicloDC(up_IFCDC_Obtener_InformeFinCicloResult objLR)
        {
            InformeFinCicloDC objInformeFinCiclo;

            try
            {
                objInformeFinCiclo = new InformeFinCicloDC();

                if (objLR != null)
                {
                    objInformeFinCiclo.InformeFinCicloId = objLR.InformeFinCicloId;
                    objInformeFinCiclo.CoordinadorId = objLR.CoordinadorId;
                    objInformeFinCiclo.CursoId = objLR.CursoId;
                    objInformeFinCiclo.PeriodoId = objLR.PeriodoId;
                    objInformeFinCiclo.DesarrolloUnidades = objLR.DesarrolloUnidades;
                    objInformeFinCiclo.ComentarioInfraestructura = objLR.ComentarioInfraestructura;
                    objInformeFinCiclo.ComentarioAlumnos = objLR.ComentarioAlumnos;
                    objInformeFinCiclo.ComentarioDelegados = objLR.ComentarioDelegados;
                    objInformeFinCiclo.ComentarioEncuesta = objLR.ComentarioEscuesta;
                    objInformeFinCiclo.UltimaActualizacion = objLR.UltimaActualizacion;
                    objInformeFinCiclo.Estado = objLR.Estado;
                }

                return objInformeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        //LOGRO
        public static LogroDC TranslateLogroLRToLogroDC(up_IFCDC_Obtener_Logro_x_CursoResult objLR)
        {
            LogroDC objLogroDC;

            try
            {
                objLogroDC = new LogroDC();

                if (objLR != null)
                {
                    objLogroDC.LogroId = objLR.LogroId;
                    objLogroDC.CursoId = objLR.CursoId;
                    objLogroDC.Descripcion = objLR.Descripcion;
                    objLogroDC.Estado = Boolean.Parse(objLR.Estado.ToString());
                }  

                return objLogroDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //CURSO_PROFESOR
        public static CursoxProfesorCollectionDC TranslateCursosxProfesorLRToCursosxProfesorCollection(List<up_IFCDC_Listar_Cursos_x_ProfesorResult> lstLR)
        {
            CursoxProfesorCollectionDC collection;

            try
            {
                collection = new CursoxProfesorCollectionDC();
                collection.LstCursosxProfesor = new Collection<CursoxProfesorDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstCursosxProfesor.Add(TranslateCursoxProfesorLRToCursoxProfesorDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CursoxProfesorDC TranslateCursoxProfesorLRToCursoxProfesorDC(up_IFCDC_Listar_Cursos_x_ProfesorResult objLR)
        {
            CursoxProfesorDC objCursoxProfesorDC;

            try
            {
                objCursoxProfesorDC = new CursoxProfesorDC();

                objCursoxProfesorDC.CursoId = objLR.CursoId;
                objCursoxProfesorDC.Codigo = objLR.Codigo;
                objCursoxProfesorDC.Nombre = objLR.Nombre;
                objCursoxProfesorDC.ProfesorId = objLR.ProfesorId;

                return objCursoxProfesorDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //HALLAZGO
        /*
        public static HallazgoCollectionDC TranslateHallazgosLRToHallazgosCollection(List<spListarHallazgosxInformeFinCicloResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoxInformeFinCicloLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static HallazgoDC TranslateHallazgoxInformeFinCicloLRToHallazgoDC(spListarHallazgosxInformeFinCicloResult objLR)
        {
            HallazgoDC objHallazgoDC;

            try
            {
                objHallazgoDC = new HallazgoDC();

                objHallazgoDC.HallazgoId = objLR.HallazgoId;
                objHallazgoDC.InformeFinCicloId = objLR.InformeFinCicloId;
                objHallazgoDC.Codigo = objLR.Codigo;
                objHallazgoDC.Descripcion = objLR.Descripcion;

                return objHallazgoDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
         
        #endregion
    }
}
