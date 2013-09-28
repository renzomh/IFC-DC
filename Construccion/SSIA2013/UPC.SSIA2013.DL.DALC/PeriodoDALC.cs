using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class PeriodoDALC
    {
        public List<up_IFCDC_Listar_PeriodosResult> listarPeriodos()
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Listar_PeriodosResult> lstPeriodos = dataContext.up_IFCDC_Listar_Periodos().ToList();

                return lstPeriodos;
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

        public up_IFCDC_Obtener_PeriodoActualResult obtenerPeriodoActual()
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                up_IFCDC_Obtener_PeriodoActualResult periodo = dataContext.up_IFCDC_Obtener_PeriodoActual().SingleOrDefault();

                return periodo;
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
