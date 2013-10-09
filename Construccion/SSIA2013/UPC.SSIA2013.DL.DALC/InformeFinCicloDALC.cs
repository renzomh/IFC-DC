using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class InformeFinCicloDALC
    {
        public up_IFCDC_Obtener_InformeFinCicloResult obtenerInformeFinCiclo(String coordinadorID, int cursoId, int periodoId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                up_IFCDC_Obtener_InformeFinCicloResult informeFinCiclo = dataContext.up_IFCDC_Obtener_InformeFinCiclo(coordinadorID, cursoId, periodoId).SingleOrDefault();

                return informeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }

        public up_IFCDC_Obtener_InformeFinCiclo_x_IdResult obtenerInformeFinCicloxId(int informeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                up_IFCDC_Obtener_InformeFinCiclo_x_IdResult informeFinCiclo = dataContext.up_IFCDC_Obtener_InformeFinCiclo_x_Id(informeFinCicloId).SingleOrDefault();

                return informeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }

        /*
        public int registrarInformeFinCiclo(String profesorId, int cursoId, int periodoId, String comentarioInfraestructura,
                                        String comentarioAlumnos, String comentarioDelegado, int calificacionDelegado)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                InformeFinCiclo objinforme = new InformeFinCiclo();
                objinforme.ProfesorId = profesorId;
                objinforme.CursoId = cursoId;
                objinforme.PeriodoId = 30;
                dataContext.InformeFinCiclo.InsertOnSubmit(objinforme);
                dataContext.SubmitChanges();
                
                return objinforme.InformeFinCicloId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }

        public spObtenerInformeFinCicloResult obtenerInformeFinCicloxProfesorxCursoxPeriodo(int informeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                spObtenerInformeFinCicloResult informeFinCiclo = dataContext.spObtenerInformeFinCiclo(informeFinCicloId).SingleOrDefault();

                return informeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
        */

        public List<up_IFCDC_Listar_Reporte_InformeFinCicloResult> listarReporteInformeInformeFinCiclo(int cursoId, int periodoId, String estado)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Listar_Reporte_InformeFinCicloResult> lstInformes = dataContext.up_IFCDC_Listar_Reporte_InformeFinCiclo(cursoId, periodoId, estado).ToList();

                return lstInformes;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
    }
}
