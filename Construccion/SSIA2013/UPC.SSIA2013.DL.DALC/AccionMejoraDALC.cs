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
        /*
        public void registrarAccionMejora(Int32 hallazgoId, Int32 informeFinCicloId, String codigo, String descripcion)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                dataContext.spRegistrarAccionMejora(hallazgoId, informeFinCicloId, codigo, descripcion);
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

        public List<spListarAccionesMejoraxHallazgoResult> listarAccionesMejoraxInformeFinCiclo(int InformeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<spListarAccionesMejoraxHallazgoResult> lstAccionesMejora = dataContext.spListarAccionesMejoraxHallazgo(InformeFinCicloId).ToList();

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

        public void editarAccionMejora(Int32 accionMejoraId, String descripcion)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                dataContext.spEditarAccionMejora(accionMejoraId, descripcion);
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

        public void eliminarAccionMejora(Int32 accionMejoraId)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                dataContext.spEliminarAccionMejora(accionMejoraId);
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
    }
}
