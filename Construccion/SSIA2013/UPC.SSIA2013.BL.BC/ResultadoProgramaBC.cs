using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.BL.BC
{
    public class ResultadoProgramaBC
    {
        public List<up_IFCDC_Listar_ResultadoPrograma_x_CursoResult> listarResultadoProgramaxCurso(int cursoId)
        {
            ResultadoProgramaDALC objResultadoProgramaDALC;

            try
            {
                objResultadoProgramaDALC = new ResultadoProgramaDALC();
                return objResultadoProgramaDALC.listarResultadoProgramaxCurso(cursoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
