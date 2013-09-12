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
