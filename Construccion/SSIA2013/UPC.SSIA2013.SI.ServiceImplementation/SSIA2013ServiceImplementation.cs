using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

using UPC.SSIA2013.BL.BC;
using UPC.SSIA2013.DL.DataModel;
using UPC.SSIA2013.SI.DataContracts;
using UPC.SSIA2013.SI.ServiceContracts;

namespace UPC.SSIA2013.SI.ServiceImplementation
{
    public class SSIA2013ServiceImplementation: SSIA2013ServiceContracts
    {
        #region metodos IFC-DC

            #region Resultado Programa

            //LISTAR RESULTADO PROGRAMA POR CURSO
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSListarResultadoProgramaxCurso")]
            ResultadoProgramaxCursoCollectionDC SSIA2013ServiceContracts.WSListarResultadoProgramaxCurso(ResultadoProgramaxCursoDC objResultadoProgramaDC)
            {
                ResultadoProgramaBC objResultadoProgramaBC = new ResultadoProgramaBC();
                return TranslatorHelper.TranslateResultadoProgramasxCursoLRToResultadoProgramaCollection(objResultadoProgramaBC.listarResultadoProgramaxCurso(objResultadoProgramaDC.CursoId));
            }
            #endregion

            #region Profesor

            //OBTENER PROFESOR
            /*
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSObtenerProfesor")]
            ProfesorDC SSIA2013ServiceContracts.WSObtenerProfesor(ProfesorDC objProfesorDC)
            {
                ProfesorBC objProfesorBC = new ProfesorBC();
                return TranslatorHelper.TranslateProfesorLRToProfesorDC(objProfesorBC.obtenerProfesor(objProfesorDC.ProfesorId));
            }
            */

            //LISTAR CURSOS POR PROFESOR
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSListarCursosxProfesor")]
            CursoxProfesorCollectionDC SSIA2013ServiceContracts.WSListarCursosxProfesor(CursoxProfesorDC objCursoxProfesorDC)
            {
                CursoBC objCursoBC = new CursoBC();
                return TranslatorHelper.TranslateCursosxProfesorLRToCursosxProfesorCollection(objCursoBC.listarCursosxProfesor(objCursoxProfesorDC.ProfesorId));
            }

            #endregion

            #region Logro Terminal

            //OBTENER LOGRO
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSObtenerLogroxCurso")]
            LogroDC SSIA2013ServiceContracts.WSListarLogroxCurso(LogroDC objLogroDC)
            {
                LogroBC objLogroBC = new LogroBC();
                return TranslatorHelper.TranslateLogroLRToLogroDC(objLogroBC.obtenerLogroxCurso(objLogroDC.CursoId));
            }
        
            #endregion

            #region Informe Fin Ciclo

            /*
            //REGISTRAR INFORME FIN CICLO
            
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSRegistrarInformeFinCiclo")]
            int SSIA2013ServiceContracts.WSRegistrarInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC)
            {
                InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
                return objInformeFinCicloBC.registrarInformeFinCiclo(objInformeFinCicloDC.ProfesorId,
                                                                    objInformeFinCicloDC.CursoId,
                                                                    objInformeFinCicloDC.PeriodoId,
                                                                    objInformeFinCicloDC.ComentarioInfraestructura,
                                                                    objInformeFinCicloDC.ComentarioAlumnos,
                                                                    objInformeFinCicloDC.ComentarioDelegado,
                                                                    objInformeFinCicloDC.CalificacionDelegado);
            }
            */

            //OBTENER INFORME FIN CICLO
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSObtenerInformeFinCicloxId")]
            InformeFinCicloDC SSIA2013ServiceContracts.WSObtenerInformeFinCicloxId(InformeFinCicloDC objInformeFinCicloDC)
            {
                InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
                return TranslatorHelper.TranslateInformeFinCicloxIdLRToInformeFinCicloDC(objInformeFinCicloBC.obtenerInformeFinCicloxId(objInformeFinCicloDC.InformeFinCicloId));
            }
            

            //OBTENER INFORME FIN CICLO (CURSO, PROFESOR, PERIODO)
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSObtenerInformeFinCiclo")]
            InformeFinCicloDC SSIA2013ServiceContracts.WSObtenerInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC)
            {
                InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
                return TranslatorHelper.TranslateInformeFinCicloLRToInformeFinCicloDC(objInformeFinCicloBC.obtenerInformeFinCiclo(objInformeFinCicloDC.CoordinadorId, objInformeFinCicloDC.CursoId, objInformeFinCicloDC.PeriodoId));
            }
            
            #endregion

            #region Hallazgos

            //REGISTRAR HALLAZGO
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSRegistrarHallazgo")]
            HallazgoCollectionDC SSIA2013ServiceContracts.WSRegistrarHallazgo(HallazgoDC objHallazgoDC)
            {
                HallazgoBC objHallazgoBC = new HallazgoBC();
                return TranslatorHelper.TranslateHallazgosRegistrarLRToHallazgosCollection(objHallazgoBC.registrarHallazgo(objHallazgoDC.InformeFinCicloId, objHallazgoDC.Descripcion));
            }

            //LISTAR HALLAZGOS
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSListarHallazgosxInformeFinCiclo")]
            HallazgoCollectionDC SSIA2013ServiceContracts.WSListarHallazgosxInformeFinCiclo(HallazgoDC objHallazgoDC)
            {
                HallazgoBC objHallazgoBC = new HallazgoBC();
                return TranslatorHelper.TranslateHallazgosListarLRToHallazgosCollection(objHallazgoBC.listarHallazgosxInformeFinCiclo(objHallazgoDC.InformeFinCicloId));
            }

            //EDITAR HALLAZGO
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSEditarHallazgo")]
            HallazgoCollectionDC SSIA2013ServiceContracts.WSEditarHallazgo(HallazgoDC objHallazgoDC)
            {
                HallazgoBC objHallazgoBC = new HallazgoBC();
                return TranslatorHelper.TranslateHallazgosEditarLRToHallazgosCollection(objHallazgoBC.editarHallazgo(objHallazgoDC.HallazgoId, objHallazgoDC.InformeFinCicloId, objHallazgoDC.Descripcion));
            }

            //ELIMINAR HALLAZGO
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSEliminarHallazgo")]
            HallazgoCollectionDC SSIA2013ServiceContracts.WSEliminarHallazgo(HallazgoDC objHallazgoDC)
            {
                HallazgoBC objHallazgoBC = new HallazgoBC();
                return TranslatorHelper.TranslateHallazgosEliminarLRToHallazgosCollection(objHallazgoBC.eliminarHallazgo(objHallazgoDC.HallazgoId, objHallazgoDC.InformeFinCicloId));
            }
 
            #endregion

            #region Acciones de Mejora
                
            /*
            //REGISTRAR ACCION DE MEJORA
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSRegistrarAccionMejora")]
            void SSIA2013ServiceContracts.WSRegistrarAccionMejora(AccionMejoraDC objAccionMejoraDC)
            {
                AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
                objAccionMejoraBC.registrarAccionMejora(objAccionMejoraDC.HallazgoId, objAccionMejoraDC.InformeFinCicloId, objAccionMejoraDC.Codigo, objAccionMejoraDC.Descripcion);
            }

            //LISTAR ACCIONES DE MEJORA
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSListarAccionesMejoraxInformeFinCiclo")]
            AccionMejoraCollectionDC SSIA2013ServiceContracts.WSListarAccionesMejoraxInformeFinCiclo(AccionMejoraDC objAccionMejoraDC)
            {
                AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
                return TranslatorHelper.TranslateAccionesMejoraLRToAccionesMejoraCollection(objAccionMejoraBC.listarAccionesMejoraxInformeFinCiclo(objAccionMejoraDC.InformeFinCicloId));
            }

            //EDITAR ACCION DE MEJORA
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSEditarAccionMejora")]
            void SSIA2013ServiceContracts.WSEditarAccionMejora(AccionMejoraDC objAccionMejoraDC)
            {
                AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
                objAccionMejoraBC.editarAccionMejora(objAccionMejoraDC.AccionMejoraId, objAccionMejoraDC.Descripcion);
            }

            //ELIMINAR ACCION DE MEJORA
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSEliminarAccionMejora")]
            void SSIA2013ServiceContracts.WSEliminarAccionMejora(AccionMejoraDC objAccionMejoraDC)
            {
                AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
                objAccionMejoraBC.eliminarAccionMejora(objAccionMejoraDC.AccionMejoraId);
            }
            */
            #endregion

            #region Persona
            
            //OBTENER PERSONA
            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSObtenerPersona")]
            PersonaDC SSIA2013ServiceContracts.WSObtenerPersona(PersonaDC objPersonaDC)
            {
                PersonaBC objPersonaBC = new PersonaBC();
                return TranslatorHelper.TranslatePersonaLRToPersonaDC(objPersonaBC.obtenerPersona(objPersonaDC.PersonaId));

            }
            #endregion

            #region Periodo

            [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/WSObtenerPeriodoActual")]
            PeriodoDC SSIA2013ServiceContracts.WSObtenerPeriodoActual()
            {
                PeriodoBC objPeriodoBC = new PeriodoBC();
                return TranslatorHelper.TranslatePeriodoLRToPeriodoDC(objPeriodoBC.obtenerPeriodo());
            }
            
            #endregion

        #endregion
    }
}
