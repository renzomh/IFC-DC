using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.BL.BC
{
    public class PeriodoBC
    {
        public List<up_IFCDC_Listar_PeriodosResult> listarPeriodos()
        {
            PeriodoDALC objPeriodoDALC;
            
            try
            {
                objPeriodoDALC = new PeriodoDALC();
                return objPeriodoDALC.listarPeriodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public up_IFCDC_Obtener_PeriodoActualResult obtenerPeriodo()
        {
            PeriodoDALC objPeriodoDALC;

            try
            {
                objPeriodoDALC = new PeriodoDALC();
                return objPeriodoDALC.obtenerPeriodoActual();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
