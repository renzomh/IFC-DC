using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.BL.BC
{
    public class LogroBC
    {
        public up_IFCDC_Obtener_Logro_x_CursoResult obtenerLogroxCurso(int? cursoId)
        {
            LogroDALC objLogroDALC;

            try
            {
                objLogroDALC = new LogroDALC();
                return objLogroDALC.obtenerLogroxCurso(cursoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
