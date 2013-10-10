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

        public static AccionMejoraCollectionDC TranslateAccionesMejoraRegistrarLRToAccionMejoraCollection(List<up_IFCDC_Registrar_AccionMejoraResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraRegistrarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraRegistrarLRToAccionMejoraDC(up_IFCDC_Registrar_AccionMejoraResult objLR)
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
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraListarLRToAccionMejoraCollection(List<up_IFCDC_Listar_AccionMejora_x_InformeFinCicloResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraListarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraListarLRToAccionMejoraDC(up_IFCDC_Listar_AccionMejora_x_InformeFinCicloResult objLR)
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
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesPreviasListarLRToAccionMejoraCollection(List<up_IFCDC_Listar_AccionMejora_PreviasResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraPreviaListarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraPreviaListarLRToAccionMejoraDC(up_IFCDC_Listar_AccionMejora_PreviasResult objLR)
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
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraEditarLRToAccionMejoraCollection(List<up_IFCDC_Editar_AccionMejoraResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraEditarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraEditarLRToAccionMejoraDC(up_IFCDC_Editar_AccionMejoraResult objLR)
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
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraPreviaEditarLRToAccionMejoraCollection(List<up_IFCDC_Editar_AccionMejora_PreviaResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraPreviaEditarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraPreviaEditarLRToAccionMejoraDC(up_IFCDC_Editar_AccionMejora_PreviaResult objLR)
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
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraEliminarLRToAccionMejoraCollection(List<up_IFCDC_Eliminar_AccionMejoraResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraEliminarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraEliminarLRToAccionMejoraDC(up_IFCDC_Eliminar_AccionMejoraResult objLR)
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
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraReporteCollectionDC TranslateAccionesMejoraEliminarLRToAccionMejoraCollection(List<up_IFCDC_Listar_Reporte_AccionMejoraResult> lstLR)
        {
            AccionMejoraReporteCollectionDC collection;

            try
            {
                collection = new AccionMejoraReporteCollectionDC();
                collection.LstAccionMejoraReporte = new Collection<AccionMejoraReporteDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionMejoraReporte.Add(TranslateAccionMejoraReporteLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraReporteDC TranslateAccionMejoraReporteLRToAccionMejoraDC(up_IFCDC_Listar_Reporte_AccionMejoraResult objLR)
        {
            AccionMejoraReporteDC obj;

            try
            {
                obj = new AccionMejoraReporteDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.Descripcion = objLR.Descripcion;
                obj.CodigoAccionMejora = objLR.CodigoAccionMejora;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public static InformeFinCicloDC TranslateInformeFinCicloxIdLRToInformeFinCicloDC(up_IFCDC_Obtener_InformeFinCiclo_x_IdResult objLR)
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

        public static InformeFinCicloDC TranslateEditarInformeFinCicloLRToInformeFinCicloDC(up_IFCDC_Editar_InformFinCicloResult objLR)
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

        public static InformeFinCicloReporteCollectionDC TranslateInformeFinCicloReporteLRToInformeFinCicloReporteCollection(List<up_IFCDC_Listar_Reporte_InformeFinCicloResult> lstLR)
        {
            InformeFinCicloReporteCollectionDC collection;

            try
            {
                collection = new InformeFinCicloReporteCollectionDC();
                collection.LstInformeFinCicloReporte = new Collection<InformeFinCicloReporteDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstInformeFinCicloReporte.Add(TranslateInformeFinCicloReporteLRToInformeFinCicloReporteDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static InformeFinCicloReporteDC TranslateInformeFinCicloReporteLRToInformeFinCicloReporteDC(up_IFCDC_Listar_Reporte_InformeFinCicloResult objLR)
        {
            InformeFinCicloReporteDC obj;

            try
            {
                obj = new InformeFinCicloReporteDC();

                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.NombreCurso = objLR.NombreCurso;
                obj.NombreProfesor = objLR.NombrePeofesor;
                obj.CodigoCurso = objLR.CodigoCurso;
                obj.Estado = objLR.Estado;
                obj.FechaActualizacion = objLR.FechaActualizacion;

                return obj;
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

        public static HallazgoCollectionDC TranslateHallazgosRegistrarLRToHallazgosCollection(List<up_IFCDC_Registrar_HallazgoResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoRegistrarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoRegistrarLRToHallazgoDC(up_IFCDC_Registrar_HallazgoResult objLR)
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

        public static HallazgoCollectionDC TranslateHallazgosListarLRToHallazgosCollection(List<up_IFCDC_Listar_Hallazgos_x_InformeFinCicloResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoListarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoListarLRToHallazgoDC(up_IFCDC_Listar_Hallazgos_x_InformeFinCicloResult objLR)
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

        public static HallazgoCollectionDC TranslateHallazgosEditarLRToHallazgosCollection(List<up_IFCDC_Editar_HallazgoResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoEditarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoEditarLRToHallazgoDC(up_IFCDC_Editar_HallazgoResult objLR)
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

        public static HallazgoCollectionDC TranslateHallazgosEliminarLRToHallazgosCollection(List<up_IFCDC_Eliminar_HallazgoResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoEliminarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoEliminarLRToHallazgoDC(up_IFCDC_Eliminar_HallazgoResult objLR)
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

        public static HallazgoReporteCollectionDC TranslateHallazgoReporteLRToHallazgoReporteCollection(List<up_IFCDC_Listar_Reporte_HallazgoResult> lstLR)
        {
            HallazgoReporteCollectionDC collection;

            try
            {
                collection = new HallazgoReporteCollectionDC();
                collection.LstHallazgoReporte = new Collection<HallazgoReporteDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgoReporte.Add(TranslateHallazgoReporteLRToHallazgoReporteDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoReporteDC TranslateHallazgoReporteLRToHallazgoReporteDC(up_IFCDC_Listar_Reporte_HallazgoResult objLR)
        {
            HallazgoReporteDC obj;

            try
            {
                obj = new HallazgoReporteDC();

                obj.HallazogId = objLR.HallazgoId;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Descripcion = objLR.Descripcion;
                obj.NombreCurso = objLR.NombreCurso;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
