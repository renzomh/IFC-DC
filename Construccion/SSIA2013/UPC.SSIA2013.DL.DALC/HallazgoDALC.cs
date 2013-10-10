using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class HallazgoDALC
    {
        public List<up_IFCDC_Registrar_HallazgoResult> registrarHallazgo(int infomeFinCicloID, String descripcion, int periodoId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Registrar_HallazgoResult> lstHallazgos = dataContext.up_IFCDC_Registrar_Hallazgo(infomeFinCicloID, descripcion, periodoId).ToList();

                return lstHallazgos;
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

        public List<up_IFCDC_Listar_Hallazgos_x_InformeFinCicloResult> listarHallazgosxInformeFinCiclo(int informeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;
            
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Listar_Hallazgos_x_InformeFinCicloResult> lstHallazgos = dataContext.up_IFCDC_Listar_Hallazgos_x_InformeFinCiclo(informeFinCicloId).ToList();
                
                return lstHallazgos;
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

        public List<up_IFCDC_Editar_HallazgoResult> editarHallazgo(int hallazgoId, int informeFinCicloId, String descripcion)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Editar_HallazgoResult> lstHallazgos = dataContext.up_IFCDC_Editar_Hallazgo(hallazgoId, descripcion, informeFinCicloId).ToList();

                return lstHallazgos;
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

        public List<up_IFCDC_Eliminar_HallazgoResult> eliminarHallazgo(int hallazgoId, int informeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Eliminar_HallazgoResult> lstHallazgos = dataContext.up_IFCDC_Eliminar_Hallazgo(hallazgoId, informeFinCicloId).ToList();

                return lstHallazgos;
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

        public List<up_IFCDC_Listar_Reporte_HallazgoResult> listarReporteHallazgo(int cursoId, int periodoId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Listar_Reporte_HallazgoResult> lstHallazgos = dataContext.up_IFCDC_Listar_Reporte_Hallazgo(cursoId, periodoId).ToList();

                return lstHallazgos;
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
