using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class AccionMejoraDALC
    {
        public List<up_IFCDC_Registrar_AccionMejoraResult> registrarAccionMejora(int hallazgoId, int informeFinCicloId, int cicloEjecucionId, String descripcion)
        {
            SSIA2013DataContext dataContext = null;
            
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Registrar_AccionMejoraResult> lstAcciones = dataContext.up_IFCDC_Registrar_AccionMejora(hallazgoId, informeFinCicloId, cicloEjecucionId, descripcion).ToList();

                return lstAcciones;
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

        public List<up_IFCDC_Listar_AccionMejora_x_InformeFinCicloResult> listarAccionesMejoraxInformeFinCiclo(int InformeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Listar_AccionMejora_x_InformeFinCicloResult> lstAccionesMejora = dataContext.up_IFCDC_Listar_AccionMejora_x_InformeFinCiclo(InformeFinCicloId).ToList();

                return lstAccionesMejora;
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

        public List<up_IFCDC_Listar_AccionMejora_PreviasResult> listarAccionesMejoraPrevias(int cursoId, int periodoId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Listar_AccionMejora_PreviasResult> lstAccionesMejora = dataContext.up_IFCDC_Listar_AccionMejora_Previas(cursoId, periodoId).ToList();

                return lstAccionesMejora;
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

        public List<up_IFCDC_Editar_AccionMejoraResult> editarAccionMejora(int accionMejoraId, int informeFinCicloId, int cicloEjecucionId, String descrpicion)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Editar_AccionMejoraResult> lstAccionesMejora = dataContext.up_IFCDC_Editar_AccionMejora(accionMejoraId, informeFinCicloId, cicloEjecucionId, descrpicion).ToList();

                return lstAccionesMejora;
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

        public List<up_IFCDC_Editar_AccionMejora_PreviaResult> editarAccionMejoraPrevia(int cursoId, int periodoId, int accioneMejoraId, String estado)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Editar_AccionMejora_PreviaResult> lstAccionesMejora = dataContext.up_IFCDC_Editar_AccionMejora_Previa(cursoId, periodoId, accioneMejoraId, estado).ToList();

                return lstAccionesMejora;
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

        public List<up_IFCDC_Eliminar_AccionMejoraResult> eliminarAccionMejora(int accionMejoraId, int informeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Eliminar_AccionMejoraResult> lstAccionesMejora = dataContext.up_IFCDC_Eliminar_AccionMejora(accionMejoraId, informeFinCicloId).ToList();

                return lstAccionesMejora;
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
