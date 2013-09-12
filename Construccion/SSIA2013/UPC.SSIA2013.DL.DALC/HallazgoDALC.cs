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
        /*
        public int registrarHallazgo(Int32? informeFinCicloId, String codigo, String descripcion)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                int hallazgoId = dataContext.spRegistrarHallazgo(informeFinCicloId, codigo, descripcion);
                
                return hallazgoId;
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

        public List<spListarHallazgosxInformeFinCicloResult> listarHallazgosxInformeFinCiclo(int? informeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;
            
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<spListarHallazgosxInformeFinCicloResult> lstHallazgos = dataContext.spListarHallazgosxInformeFinCiclo(informeFinCicloId).ToList();
                
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

        public void editarHallazgo(Int32 hallazgoId, String descripcion)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                dataContext.spEditarHallazgo(hallazgoId, descripcion);
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

        public void eliminarHallazgo(Int32 hallazgoId)
        {
            SSIA2013DataContext dataContext = null;
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                dataContext.spEliminarHallazgo(hallazgoId);
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
        }*/
    }
}
